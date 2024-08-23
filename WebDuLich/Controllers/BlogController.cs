using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.Controllers
{
    public class BlogController : Controller
    {

        private readonly QLDLContext _context;

        public BlogController(QLDLContext context)
        {
            _context = context;
        }

        [Route("blogs.html", Name ="Blog")]
        public async Task<IActionResult> IndexBlog(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var IsNews = _context.News
                .AsNoTracking()
                .OrderByDescending(x => x.PostId);

            PagedList<News> models = new PagedList<News>(IsNews, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }


        [Route("/tintuc/{id}.html", Name ="TinDetails")]
        public IActionResult DetailsBlog(int id)
        {
            var tindang = _context.News.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (tindang == null)
            {
                ViewBag.ErrorMessage = "Không tìm thấy sản phẩm";
                //return RedirectToAction("IndexShopTour");

            }
            var lsBaiVietLienQuan = _context.News
                .AsNoTracking()
                .Where(x => x.Publish == true && x.PostId != id)
                .Take(3).OrderByDescending(x => x.CreateDate)
                .ToList();
            ViewBag.lsBaiVietLienQuan = lsBaiVietLienQuan;
            return View(tindang);
        }


       
    }
}
