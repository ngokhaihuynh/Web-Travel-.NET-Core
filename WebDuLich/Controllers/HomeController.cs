using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;
using WebDuLich.ModelViews;

namespace WebDuLich.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QLDLContext _context;

        public HomeController(ILogger<HomeController> logger , QLDLContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            // load sản phẩm lên trang chủ
            HomeViewVM model = new HomeViewVM();

            var lsProducts = _context.Products
                .AsNoTracking()
                .Where(x => x.Actice == true && x.HomeFlag == true) // điều kiện hiển thị trang chủ
                .OrderByDescending(x => x.CreateDate)
                .Take(6)
                .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();
            
            var lsCats = _context.Categories
                .AsNoTracking()
                .Where(x => x.Publish == true)
                .OrderByDescending(x => x.Location)
                .ToList();

            foreach (var item in lsCats)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProduct = lsProducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);
            }




            // load phan tin tuc
            var TinTuc = _context.News
                .AsNoTracking()
                .Where(x => x.Publish == true && x.IsNewFeed == true) // dieu kien upload len trang chu
                .OrderByDescending(x => x.CreateDate)
                .Take(4)
                .ToList();

            model.Products = lsProductViews;
            model.news = TinTuc;
            ViewBag.AllProducts = lsProducts;
            return View(model);
        }




        //public IActionResult Index()
        //{
        //    return View();
        //}
        [Route("lien-he.html", Name = "Contact")]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("lien-he.html", Name = "Contact")]
        public async Task<IActionResult> Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                // Tạo một đối tượng Contact từ dữ liệu mẫu
                var contact = new Contact
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Phone = model.Phone,
                    Note = model.Note,
                    CreatedAt = DateTime.Now
                };

                // Thêm đối tượng Contact vào cơ sở dữ liệu
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();

                // Chuyển hướng đến một trang khác (ví dụ: trang xác nhận)
                return RedirectToAction("ContactConfirmation");
            }

            // Nếu dữ liệu không hợp lệ, hiển thị lại form liên hệ với thông báo lỗi
            return View(model);
        }

        public IActionResult ContactConfirmation()
        {
            return View();
        }

        [Route("gioi-thieu.html", Name = "About")]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       




    }
}
