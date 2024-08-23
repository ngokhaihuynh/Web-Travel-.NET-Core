using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList;
using WebDuLich.Helper;
using WebDuLich.Models;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPagesController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }

        public AdminPagesController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
           
        }

        // GET: Admin/AdminPages



  
        public async Task<IActionResult> Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var IsPages = _context.Pages
                .AsNoTracking()
                .OrderByDescending(x => x.PageId);

            PagedList<Page> models = new PagedList<Page>(IsPages, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
           
            return View(models);


            //    var qLDLContext = _context.Customers.Include(c => c.Location);
            //    return View(await qLDLContext.ToListAsync());
            //
        }

        // GET: Admin/AdminPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // GET: Admin/AdminPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageId,PageName,Contents,Image,Publish,Title,MetaDesc,MetaKey,CreatDate,Alias")] Page page, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (ModelState.IsValid)
            {
           
                // xử lí ảnh
                if (fImage != null)
                {
                    string extension = Path.GetExtension(fImage.FileName);
                    string ImageName = Utilities.SEOUrl(page.PageName) + extension;  
                    page.Image = await Utilities.UploadFile(fImage, @"pages", ImageName.ToLower());

                }
                if (string.IsNullOrEmpty(page.Image)) page.Image = "default.jpg";
                page.Alias = Utilities.SEOUrl(page.PageName);

                _context.Add(page);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm sản phẩm thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(page);
        }

        // GET: Admin/AdminPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }
            return View(page);
        }

        // POST: Admin/AdminPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageId,PageName,Contents,Image,Publish,Title,MetaDesc,MetaKey,CreatDate,Alias")] Page page, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (id != page.PageId)
            {
                return NotFound();
                
            }

            if (ModelState.IsValid)
            {
                try
                {

                    // xử lí ảnh
                    if (fImage != null)
                    {
                        string extension = Path.GetExtension(fImage.FileName);
                        string ImageName = Utilities.SEOUrl(page.PageName) + extension;
                        page.Image = await Utilities.UploadFile(fImage, @"pages", ImageName.ToLower());

                    }
                    if (string.IsNullOrEmpty(page.Image)) page.Image = "default.jpg";
                    page.Alias = Utilities.SEOUrl(page.PageName);

                    _context.Update(page);
                    _notyfService.Success("Cập nhật sản phẩm thành công");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageExists(page.PageId))
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
            return View(page);
        }

        // GET: Admin/AdminPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: Admin/AdminPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var page = await _context.Pages.FindAsync(id);
            _context.Pages.Remove(page);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa sản phẩm thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool PageExists(int id)
        {
            return _context.Pages.Any(e => e.PageId == id);
        }
    }
}
