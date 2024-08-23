using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Route("Admin", Name = "AdminHome")]
    public class HomeController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public HomeController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }


        public IActionResult Index()
        {
            // Lấy danh sách các đơn hàng có trạng thái hoàn thành và TransactId = 3
            var completedOrders = _context.Orders.Where(o => o.TransactId == 3).ToList();

            // Cập nhật trạng thái paid của các đơn hàng
            foreach (var order in completedOrders)
            {
                order.Paid = true;
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            _context.SaveChanges();

            // Tính tổng doanh thu từ các đơn hàng đã thanh toán
            decimal totalRevenue = _context.Orders.Where(o => o.Paid == true).Sum(o => o.TotalMoney);

            // Đặt tổng doanh thu vào ViewBag để truyền sang view
            ViewBag.TotalRevenue = totalRevenue;

            return View();
        }

    }
}
