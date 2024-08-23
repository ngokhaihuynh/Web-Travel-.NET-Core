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
    public class AdminCategoriesController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public AdminCategoriesController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminCategories
        public async Task<IActionResult> Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var IsCategorys = _context.Categories
                .AsNoTracking()
                .OrderByDescending(x => x.CatId);

            PagedList<Category> models = new PagedList<Category>(IsCategorys, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);


           
        }

        // GET: Admin/AdminCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/AdminCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatName,Description,ParentId,Levels,Location,Publish,Image,Title")] Category category, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (ModelState.IsValid)
            {
                // xử lí ảnh
                if (fImage != null)
                {
                    string extension = Path.GetExtension(fImage.FileName);
                    string ImageName = Utilities.SEOUrl(category.CatName) + extension;
                    category.Image = await Utilities.UploadFile(fImage, @"Categories", ImageName.ToLower());

                }
                if (string.IsNullOrEmpty(category.Image)) category.Image = "default.jpg";





                _context.Add(category);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm sản phẩm thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/AdminCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/AdminCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CatName,Description,ParentId,Levels,Location,Publish,Image,Title")] Category category, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (id != category.CatId)
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
                        string ImageName = Utilities.SEOUrl(category.CatName) + extension;
                        category.Image = await Utilities.UploadFile(fImage, @"Categories", ImageName.ToLower());

                    }
                    if (string.IsNullOrEmpty(category.Image)) category.Image = "default.jpg";


                    _context.Update(category);
                    _notyfService.Success("Cập nhật sản phẩm thành công");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CatId))
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
            return View(category);
        }

        // GET: Admin/AdminCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admin/AdminCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa sản phẩm thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CatId == id);
        }
    }
}
