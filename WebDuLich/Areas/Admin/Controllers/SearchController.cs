using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly QLDLContext _context;

        public SearchController(QLDLContext context)
        {
            _context = context;
        }
        // GET: Search product
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }

            ls = _context.Products
                                    .AsNoTracking()
                                    .Include(a => a.Cat)
                                    .Where(x => x.ProductName.Contains(keyword))
                                    .OrderByDescending(x => x.ProductName)
                                    .Take(10)
                                    .ToList();
            if(ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }

        }

    }
}
