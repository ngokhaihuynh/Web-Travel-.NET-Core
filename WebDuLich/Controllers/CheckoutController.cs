using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Extension;
using WebDuLich.Helper;
using WebDuLich.Models;
using WebDuLich.ModelViews;

namespace WebDuLich.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public CheckoutController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }

                return gh;
            }
        }


        // get: checkout/ index

        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CusId");
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                model.CusId = khachhang.CusId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

            }

            ViewBag.GioHang = cart;

            // Kiểm tra và chuyển hướng người dùng nếu returnUrl có giá trị
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction("Login", "Account", new { returnUrl = returnUrl });
            }

            return View(model);
        }



        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CusId");
            ModelState.Clear();
            MuaHangVM model = muaHang;


            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                if (khachhang != null)
                {
                    khachhang.Address = muaHang.Address;

                    _context.Update(khachhang);
                    _context.SaveChanges();

                    if (ModelState.IsValid)
                    {
                        // Tạo đơn hàng
                        Order donhang = new Order();
                        donhang.CusId = model.CusId;
                        donhang.Address = model.Address;
                        donhang.OrderDate = DateTime.Now;
                        donhang.TransactId = 1;
                        donhang.Deteled = false;
                        donhang.Paid = false;
                        donhang.Note = Utilities.StripHTML(model.Note);
                        donhang.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                        donhang.NgayDi = model.NgayDi;
                        _context.Add(donhang);
                        _context.SaveChanges();
                        // danh sach don hang
                        foreach (var item in cart)
                        {
                            Orderdetail orderdetail = new Orderdetail();
                            orderdetail.OrderId = donhang.OrderId;
                            orderdetail.ProductId = item.product.ProductId;
                            orderdetail.Quantity = item.amount;
                            orderdetail.Price = item.product.Price;
                            orderdetail.Total = item.amount * item.product.Price; // tính tổng tiền cho từng sản phẩm
                            orderdetail.CreateDate = DateTime.Now;
                            _context.Add(orderdetail);
                        }
                        _context.SaveChanges();
                        // clear gio hang
                        HttpContext.Session.Remove("GioHang");
                        // thong báo
                        _notyfService.Success("Đặt hàng thành công!");
                        return RedirectToAction("Success", "Checkout"); // Chuyển hướng đến trang thành công
                    }
                }
            }
            
            ViewBag.GioHang = cart;
            return View(model);
        }




        [Route("dat-hang-thanh-cong.html", Name = "Success")]
        public IActionResult Success()
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CusId");
                if (string.IsNullOrEmpty(taikhoanID))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/dat-hang-thanh-cong.html" });
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                var donhang = _context.Orders.Where(x => x.CusId == Convert.ToInt32(taikhoanID)).OrderByDescending(x => x.OrderDate);
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.Phone = khachhang.Phone;
                successVM.Address = khachhang.Address;

                return View(successVM);
            }
            catch
            {
                return View();
            }
            
        }
    }
}
