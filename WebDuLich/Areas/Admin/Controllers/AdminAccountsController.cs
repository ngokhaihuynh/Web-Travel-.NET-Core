using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDuLich.Extension;
using WebDuLich.Helper;
using WebDuLich.Models;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAccountsController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public AdminAccountsController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminAccounts
        public async Task<IActionResult> Index()
        {
            //lọc
            ViewData["QuyenTruyCap"] = new SelectList(_context.Roles, "RoleId", "Description");

            List<SelectListItem> IsTrangThai= new List<SelectListItem>();
            IsTrangThai.Add(new SelectListItem() { Text = "Kích hoạt", Value = "1" });
            IsTrangThai.Add(new SelectListItem() { Text = "Khóa", Value = "0" });
            ViewData["IsTrangThai"] = IsTrangThai;

            var qLDLContext = _context.Accounts.Include(a => a.Role);
            
            return View(await qLDLContext.ToListAsync());
        }

        // GET: Admin/AdminAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.AccId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/AdminAccounts/Create
        public IActionResult Create()
        {
            //ViewData["QuyenTruyCap"] = new SelectList(_context.Roles, "RoleId", "RoleName");
            // Truy vấn danh sách vai trò từ database và chuyển thành SelectList
            var roles = _context.Roles.Select(r => new SelectListItem
            {
                Value = r.RoleId.ToString(),
                Text = r.RoleName // Sử dụng tên vai trò làm giá trị hiển thị
            }).ToList();

            // Gán danh sách vai trò vào ViewBag.RoleId
            ViewBag.RoleId = roles;

           
            return View();
        }

        // POST: Admin/AdminAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccId,FullName,Phone,Email,Password,Encode,Active,Access,LastLogin,CreateDate,RoleId")] Account account)
        {
            if (ModelState.IsValid)
            {
                string salt = Utilities.GetRandomKey();
                account.Salt = salt;
                // tao ngau nhien mat khau
                account.Password = (account.Phone + salt.Trim()).ToMD5();
                account.CreateDate = DateTime.Now;

                _context.Add(account);
                await _context.SaveChangesAsync();
                _notyfService.Success("tạo tài khoản thành công!");
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", account.RoleId);
            return View(account);
        }

        // GET: Admin/AdminAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", account.RoleId);
            return View(account);
        }

        // POST: Admin/AdminAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccId,FullName,Phone,Email,Password,Encode,Active,Access,LastLogin,CreateDate,RoleId")] Account account)
        {
            if (id != account.AccId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.AccId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", account.RoleId);
            var roles = _context.Roles.Select(r => new SelectListItem
            {
                Value = r.RoleId.ToString(),
                Text = r.RoleName // Sử dụng tên vai trò làm giá trị hiển thị
            }).ToList();

            // Gán danh sách vai trò vào ViewBag.RoleId
            ViewBag.RoleId = roles;

        
            return View(account);


        }




        // GET: Admin/AdminAccounts/ChangePassword
        [HttpPost]
        public IActionResult ChangePassword()
        {
            ViewData["QuyenTruyCap"] = new SelectList(_context.Roles, "RoleId", "RoleName");
            return View();
        }

        // GET: Admin/AdminAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.AccId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admin/AdminAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.AccId == id);
        }
    }
}
