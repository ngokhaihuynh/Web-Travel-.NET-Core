using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using PagedList.Core.Mvc;
using WebDuLich.Helper;
using WebDuLich.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductsController : Controller
    {
        private readonly QLDLContext _context;

        public INotyfService _notyfService { get;  }

        public AdminProductsController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminProducts
        public IActionResult Index(int page = 1, int CatID = 0)
        {
            var pageNumber = page;
            var pageSize = 20;

            List<Product> IsProducts = new List<Product>();

            if (CatID != 0)
            {
                IsProducts = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == CatID)
                    .Include(x => x.Cat)
                    .OrderByDescending(x => x.ProductId).ToList();

            }
            else
            {
                IsProducts = _context.Products
                    .AsNoTracking()
                    .Include(x => x.Cat)
                    .OrderByDescending(x => x.ProductId)
                    .ToList();
            }

            PagedList<Product> models = new PagedList<Product>(IsProducts.AsQueryable(), pageNumber, pageSize);

            ViewBag.CurrentCatID = CatID;
            ViewBag.CurrentPage = pageNumber;
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", CatID);

            return View(models);
        }



        public IActionResult Filtter(int CatId = 0)
        {
            var url = $"/Admin/AdminProducts/?CatId={CatId}";
            if (CatId == 0)
            {
                url = $"/Admin/AdminProducts";
            }
            return Json(new { status = "success", RedirectUrl = url });
        }


        // GET: Admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/AdminProducts/Create
        public IActionResult Create()
        {
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: Admin/AdminProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Image,Video,CreateDate,CreateModified,BestSeller,HomeFlag,Actice,Tags,Title,MetaDesc,MetaKey,StockingTour,thumb, Address")] Product product, Microsoft.AspNetCore.Http.IFormFile fImage)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        product.ProductName = Utilities.ToTitleCase(product.ProductName);

        //        string description = product.Description;
        //        if (fImage != null)
        //        {
        //            string extension = Path.GetExtension(fImage.FileName);
        //            string image = Utilities.SEOUrl(product.ProductName) + extension;
        //            product.Image = await Utilities.UploadFile(fImage, @"products", image.ToLower());

        //        }
        //        if (string.IsNullOrEmpty(product.Image)) product.Image = "default.jpg";

        //        //product.Alias = Utilities.SEOUrl(product.ProductName);
        //        product.CreateModified = DateTime.Now;
        //        product.CreateDate = DateTime.Now;
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        _notyfService.Success("Thêm sản phẩm thành công");
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
        //    return View(product);
        //}


        public async Task<IActionResult> Create(
        [Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Image,Video,CreateDate,CreateModified,BestSeller,HomeFlag,Actice,Tags,Title,MetaDesc,MetaKey,StockingTour,thumb,Address")] Product product,
        Microsoft.AspNetCore.Http.IFormFile fImage,
        List<Microsoft.AspNetCore.Http.IFormFile> fImages)
        {
            if (ModelState.IsValid)
            {
                // Chuyển tên sản phẩm thành chữ cái đầu viết hoa
                product.ProductName = Utilities.ToTitleCase(product.ProductName);

                // Xử lý upload hình ảnh chính nếu có
                if (fImage != null)
                {
                    // Lấy phần mở rộng của tệp hình ảnh
                    string extension = Path.GetExtension(fImage.FileName);
                    // Tạo tên tệp hình ảnh mới dựa trên tên sản phẩm
                    string image = Utilities.SEOUrl(product.ProductName) + extension;
                    // Tải lên tệp hình ảnh và lưu tên tệp vào thuộc tính Image của sản phẩm
                    product.Image = await Utilities.UploadFile(fImage, @"products", image.ToLower());
                }

                // Nếu không có hình ảnh chính, gán giá trị mặc định
                if (string.IsNullOrEmpty(product.Image))
                    product.Image = "default.jpg";

                // Xử lý upload nhiều hình ảnh nếu có
                if (fImages != null && fImages.Count > 0)
                {
                    List<string> imageNames = new List<string>();

                    // Lặp qua danh sách tệp hình ảnh và tải lên từng tệp
                    foreach (var file in fImages)
                    {
                        // Lấy phần mở rộng của tệp hình ảnh
                        string extension = Path.GetExtension(file.FileName);
                        // Tạo tên tệp hình ảnh mới duy nhất với GUID
                        string imageName = Guid.NewGuid().ToString() + extension;
                        // Tải lên tệp hình ảnh và lưu tên tệp vào biến uploadedImageName
                        string uploadedImageName = await Utilities.UploadFile(file, @"dtproducts", imageName.ToLower());

                        // Nếu tải lên thành công, thêm tên tệp vào danh sách
                        if (!string.IsNullOrEmpty(uploadedImageName))
                        {
                            imageNames.Add(uploadedImageName);
                        }
                    }

                    // Gán danh sách tên tệp vào thuộc tính Images của sản phẩm
                    product.Images = string.Join(";", imageNames);
                }

                // Gán ngày tạo và ngày sửa cho sản phẩm
                product.CreateModified = DateTime.Now;
                product.CreateDate = DateTime.Now;

                // Thêm sản phẩm vào context và lưu thay đổi
                _context.Add(product);
                await _context.SaveChangesAsync();

                // Hiển thị thông báo thành công
                _notyfService.Success("Thêm sản phẩm thành công");

                // Chuyển hướng đến trang danh sách sản phẩm
                return RedirectToAction(nameof(Index));
            }

            // Nếu dữ liệu không hợp lệ, hiển thị lại form với dữ liệu đã nhập
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }


        // GET: Admin/AdminProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // POST: Admin/AdminProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Image,Video,CreateDate,CreateModified,BestSeller,HomeFlag,Actice,Tags,Title,MetaDesc,MetaKey,StockingTour,thumb,Address")] Product product, Microsoft.AspNetCore.Http.IFormFile fImage)
        //{
        //    if (id != product.ProductId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            product.ProductName = Utilities.ToTitleCase(product.ProductName);


        //            if (fImage != null && fImage.Length > 0)
        //            {
        //                string extension = Path.GetExtension(fImage.FileName);
        //                string image = Utilities.SEOUrl(product.ProductName) + extension;
        //                product.Image = await Utilities.UploadFile(fImage, @"products", image.ToLower());

        //            }
        //            if (string.IsNullOrEmpty(product.Image)) product.Image = "default.jpg";

        //            //product.Alias = Utilities.SEOUrl(product.ProductName);
        //            product.CreateModified = DateTime.Now;

        //            _context.Update(product);
        //            _notyfService.Success("Cập nhật sản phẩm thành công");
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductExists(product.ProductId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
        //    return View(product);
        //}
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Image,Images,Video,CreateDate,CreateModified,BestSeller,HomeFlag,Actice,Tags,Title,MetaDesc,MetaKey,StockingTour,thumb,Address")] Product product, IEnumerable<IFormFile> fImages, IFormFile fImage)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    product.ProductName = Utilities.ToTitleCase(product.ProductName);

                    // Xử lý tải lên và lưu ảnh mới (ảnh đại diện)
                    if (fImage != null && fImage.Length > 0)
                    {
                        string extension = Path.GetExtension(fImage.FileName);
                        string imageName = Utilities.SEOUrl(product.ProductName) + extension;
                        product.Image = await Utilities.UploadFile(fImage, @"products", imageName.ToLower());
                    }

                    // Xử lý tải lên và cập nhật danh sách ảnh khác
                    if (fImages != null && fImages.Any()) // Kiểm tra xem có ảnh được tải lên không
                    {
                        List<string> imagePaths = new List<string>();

                        foreach (var f in fImages)
                        {
                            if (f != null && f.Length > 0)
                            {
                                string extension = Path.GetExtension(f.FileName);
                                string imageName = Utilities.SEOUrl(product.ProductName) + extension;
                                string imagePath = await Utilities.UploadFile(f, @"dtproducts", imageName.ToLower());

                                // Thêm đường dẫn ảnh mới vào danh sách tạm thời
                                imagePaths.Add(imagePath);
                            }
                        }

                        // Nếu danh sách ảnh tạm thời có phần tử
                        if (imagePaths.Any())
                        {
                            // Nếu danh sách ảnh của sản phẩm đã có ảnh, thêm vào danh sách mới
                            if (!string.IsNullOrEmpty(product.Images))
                            {
                                // Tách các đường dẫn ảnh hiện tại thành mảng
                                var existingImages = product.Images.Split(';').ToList();

                                // Loại bỏ những đường dẫn ảnh trùng lặp trong danh sách mới
                                imagePaths = imagePaths.Except(existingImages).ToList();

                                // Thêm các đường dẫn mới vào danh sách ảnh của sản phẩm
                                product.Images += ";" + string.Join(";", imagePaths);
                            }
                            else
                            {
                                // Nếu danh sách ảnh của sản phẩm trống, thêm đường dẫn mới vào
                                product.Images = string.Join(";", imagePaths);
                            }
                        }
                    }

                    // Xử lý logic khi không có ảnh
                    if (string.IsNullOrEmpty(product.Image))
                    {
                        product.Image = "default.jpg";
                    }

                    if (string.IsNullOrEmpty(product.Images))
                    {
                        product.Images = "default.jpg";
                    }
                    else
                    {
                        // Loại bỏ dấu ; ở đầu nếu có
                        if (product.Images.StartsWith(";"))
                        {
                            product.Images = product.Images.Substring(1);
                        }
                    }

                    product.CreateModified = DateTime.Now;

                    _context.Update(product);
                    _notyfService.Success("Cập nhật sản phẩm thành công");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // GET: Admin/AdminProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/AdminProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa sản phẩm thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
