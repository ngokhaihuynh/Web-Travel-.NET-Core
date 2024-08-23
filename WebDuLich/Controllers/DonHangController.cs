using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;
using WebDuLich.ModelViews;

namespace WebDuLich.Controllers
{
    public class DonHangController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public DonHangController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [HttpPost]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CusId");
                if (string.IsNullOrEmpty(taikhoanID)) return RedirectToAction("Login", "Accounts");
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                if (khachhang == null) return NotFound();
                var donhang = await _context.Orders
                    .Include(x => x.Status)
                    .FirstOrDefaultAsync(m => m.OrderId == id && Convert.ToInt32(taikhoanID) == m.CusId);
                if (donhang == null)
                {
                    return NotFound();
                }
                var chitietdonhang = _context.Orderdetails
                    .Include(x => x.Product)
                    .AsNoTracking()
                    .Where(x => x.OrderId == id)
                    .OrderBy(x => x.OrderDetailId)
                    .ToList();
                XemDonHang donHang = new XemDonHang();
                donHang.DonHang = donhang;
                donHang.ChiTietDonHang = chitietdonhang;

                return PartialView("Details", donHang);
            }
            catch
            {
                return NotFound();
            }
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
