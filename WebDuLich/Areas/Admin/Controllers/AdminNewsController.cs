using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebDuLich.Helper;
using WebDuLich.Models;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminNewsController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public AdminNewsController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminNews
        public async Task<IActionResult> Index(int? page)
        {


            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var IsNews = _context.News
                .AsNoTracking()
                .OrderByDescending(x => x.PostId);

            PagedList<News> models = new PagedList<News>(IsNews, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);


            //    var qLDLContext = _context.Customers.Include(c => c.Location);
            //    return View(await qLDLContext.ToListAsync());
            //
        }

        // GET: Admin/AdminNews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.Acc)
                .Include(n => n.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: Admin/AdminNews/Create
        public IActionResult Create()
        {
            ViewData["AccId"] = new SelectList(_context.Accounts, "AccId", "AccId");
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatId");
            return View();
        }

        // POST: Admin/AdminNews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Tile,ShortContent,Contents,Image,Publish,CreateDate,Author,CatId,AccId,Tags,IsHot,IsNewFeed,MetaDesc,MetaKey,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (ModelState.IsValid)
            {

                // xử lí ảnh
                if (fImage != null)
                {
                    string extension = Path.GetExtension(fImage.FileName);
                    string ImageName = Utilities.SEOUrl(news.Tile) + extension;
                    news.Image = await Utilities.UploadFile(fImage, @"news", ImageName.ToLower());

                }
                if (string.IsNullOrEmpty(news.Image)) news.Image = "default.jpg";
                news.CreateDate = DateTime.Now;
                _context.Add(news);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm sản phẩm thành công");
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccId"] = new SelectList(_context.Accounts, "AccId", "AccId", news.AccId);
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatId", news.CatId);
            return View(news);
        }

        // GET: Admin/AdminNews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            ViewData["AccId"] = new SelectList(_context.Accounts, "AccId", "AccId", news.AccId);
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatId", news.CatId);
            return View(news);
        }

        // POST: Admin/AdminNews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Tile,ShortContent,Contents,Image,Publish,CreateDate,Author,CatId,AccId,Tags,IsHot,IsNewFeed,MetaDesc,MetaKey,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (id != news.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (fImage != null)
                    {
                        string extension = Path.GetExtension(fImage.FileName);
                        string ImageName = Utilities.SEOUrl(news.Tile) + extension;
                        news.Image = await Utilities.UploadFile(fImage, @"news", ImageName.ToLower());

                    }
                    if (string.IsNullOrEmpty(news.Image)) news.Image = "default.jpg";
                    news.CreateDate = DateTime.Now;
                    _context.Update(news);
                    _notyfService.Success("Cập nhật sản phẩm thành công");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.PostId))
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
            ViewData["AccId"] = new SelectList(_context.Accounts, "AccId", "AccId", news.AccId);
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatId", news.CatId);
            return View(news);
        }

        // GET: Admin/AdminNews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.Acc)
                .Include(n => n.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: Admin/AdminNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa sản phẩm thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.PostId == id);
        }
    }
}
