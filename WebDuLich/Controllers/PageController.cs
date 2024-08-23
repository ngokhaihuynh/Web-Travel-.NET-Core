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
    public class PageController : Controller
    {
        private readonly QLDLContext _context;

        public PageController(QLDLContext context)
        {
            _context = context;
        }


        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if(string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
               

            }
            return View(page);
           
        }

    }
}
