using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.Controllers
{
    public class LocationController : Controller
    {
        private readonly QLDLContext _context;
      
        public LocationController(QLDLContext context)
        {
            _context = context;
           
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult QuanHuyenList(int locationId)
        {
            var QuanHuyens = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.ParentCode == locationId && x.Levels == 2)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(QuanHuyens);
        }
        public ActionResult PhuongXaList(int locationId)
        {
            var PhuongXas = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.ParentCode == locationId && x.Levels == 3)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(PhuongXas);
        }           
    }
}
