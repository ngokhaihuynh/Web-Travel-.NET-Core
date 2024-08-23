using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.Controllers
{
   
    public class ProductController : Controller
    {
        private readonly QLDLContext _context;

        public ProductController(QLDLContext context)
        {
            _context = context;
        }



        [Route("shop.html", Name = "ShopProduct")]
        public IActionResult IndexShopTour(int? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 20;
                var IsNews = _context.Products
                    .AsNoTracking()
                    .OrderByDescending(x => x.CreateDate);

                PagedList<Product> models = new PagedList<Product>(IsNews, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
  
        }

        [Route("/{id}", Name = "ListProduct")]
        public IActionResult List(int id, int page = 1)
        {
            try
            {

                var pageSize = 10;
                var danhmuc = _context.Categories.Find(id);
                var IsNews = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == id)
                    .OrderByDescending(x => x.CreateDate);

                PagedList<Product> models = new PagedList<Product>(IsNews, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;

                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

            
        }


        [Route("/{id}.html", Name = "ProductDetails")]
        public IActionResult Details(int id)
        {

            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    ViewBag.ErrorMessage = "Không tìm thấy sản phẩm";
                    //return RedirectToAction("IndexShopTour");

                }

                var lsProduct = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Actice == true)
                    .Take(6)
                    .OrderByDescending(x => x.CreateDate)
                    .ToList();

                ViewBag.SanPham = lsProduct;
                return View(product);



            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
           
        }



      
        // tìm kiém sản phẩm
        [HttpGet]
        [Route("Tim-kiem.html", Name = "TimKiem")]
       public IActionResult Search(string prname, int? to, int? from)
        {
            var sanpham = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(prname))
            {
                sanpham = sanpham.Where(x => x.ProductName.Contains(prname));
            }

            if (to != null && from != null)
            {
                sanpham = sanpham.Where(x => x.Price >= to && x.Price <= from);
            }

            return View(sanpham.ToList());
        }



        // lọc sản phẩm
       [Route("Xem-tour.html", Name = "ShowTour")]
        public IActionResult ShowTour(int? CategoryId, string address)
        {
            var catid = CategoryId ?? 0;

            // Lấy danh sách các danh mục tour để hiển thị trong dropdown
            var categories = _context.Categories.ToList();
            categories.Insert(0, new Category { CatId = 0, CatName = "Chọn Loại tour" });
            ViewBag.CategoryId = new SelectList(categories, "CatId", "CatName", catid);

            // Lấy danh sách các địa chỉ từ bảng sản phẩm
            var addresses = _context.Products.Select(x => x.Address).Distinct().ToList();
            addresses.Insert(0, "Chọn Địa chỉ");
            ViewBag.Addresses = new SelectList(addresses);

            // Lọc sản phẩm theo danh mục tour được chọn
            var sanpham = _context.Products.Where(x => x.CatId == catid);

            // Lọc sản phẩm theo địa chỉ (nếu được chọn)
            if (!string.IsNullOrEmpty(address) && address != "Chọn Địa chỉ")
            {
                sanpham = sanpham.Where(x => x.Address == address);
            }

            return View(sanpham.ToList());
        }
       
        




    }
}
