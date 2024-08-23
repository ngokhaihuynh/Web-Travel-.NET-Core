using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebDuLich.Extension;
using WebDuLich.Helper;
using WebDuLich.Models;
using WebDuLich.ModelViews;

namespace WebDuLich.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public AccountsController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if(khachhang != null)
                    return Json(data: " số điện thoại: " + Phone + "Đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                    return Json(data: " số điện thoại: " + Email + "Đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        

        [Route("tai-khoan-cua-toi.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetString("CusId");
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                if(khachhang != null)
                {
                    var lsDonhang = _context.Orders
                        .Include(x => x.Transact)
                        .AsNoTracking()
                        .Where(x => x.CusId == khachhang.CusId)
                        .OrderByDescending(x => x.OrderDate).ToList();
                    ViewBag.Donhang = lsDonhang;

                    return View(khachhang);
                }
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangKyTaiKhoan()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangKyTaiKhoan(RegisterVM taikhoan)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer khachhang = new Customer
                    {
                        FullName = taikhoan.FullName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Password = (taikhoan.Password + salt.Trim()).ToMD5(),
                        Active = true,
                        Salt = salt,
                        CreateDate = DateTime.Now

                    };
                    try
                    {
                        _context.Add(khachhang);
                        await _context.SaveChangesAsync();
                        // luu Session ma khach hang

                        HttpContext.Session.SetString("CusId", khachhang.CusId.ToString());
                        var taikhoanID = HttpContext.Session.GetString("CusId");
                        //Identity
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, khachhang.FullName),
                            new Claim("CusId", khachhang.CusId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                  
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch(Exception ex)
                    {
                        return RedirectToAction("DangKyTaiKhoan", "Accounts");
                   
                    }
                }
                else
                {
                    return View(taikhoan);
                }
            }
            catch
            {
                return View(taikhoan);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CusId");
            if(taikhoanID != null)
            {
         
                return RedirectToAction("Dashboard", "Accounts");
            }
       
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }



        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.UserName);
                    if (!isEmail) return View(customer);

                    var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == customer.UserName);
                    if (khachhang == null) return RedirectToAction("DangKyTaiKhoan");

                    string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                    if (khachhang.Password != pass)
                    {
                        //ViewBag.Error = "+ Sai thông tin đăng nhập";
                        _notyfService.Success("Thông tin đăng nhập chưa chính xác");
                        return View(customer);
                    }

                    // kiểm tra acc có disable 
                    if (khachhang.Active == false)
                    {
                        return RedirectToAction("Thông báo", "Accounts");
                    }

                    // luu ss makh
                    HttpContext.Session.SetString("CusId", khachhang.CusId.ToString());
                    var taikhoanID = HttpContext.Session.GetString("CusId");
                    // identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, khachhang.FullName),
                        new Claim("CusId", khachhang.CusId.ToString())

                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notyfService.Success("Đăng nhập thành công!");
                    return RedirectToAction("Dashboard", "Accounts");
                }
            }
            catch
            {
                return RedirectToAction("DangKyTaiKhoan", "Accounts");
            }

            return View(customer);
        }


        [HttpGet]
        [Route("dang-xuat.html", Name ="Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CusId");
            return RedirectToAction("Index", "Home");
        }


        //public IActionResult ModalChangePassword()
        //{
        //    return PartialView("ChangePasword");

        //}



        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CusId");
                if (taikhoanID == null)
                {
                    // Nếu không có phiên đăng nhập, chuyển hướng đến trang đăng nhập
                    return RedirectToAction("Login", "Accounts");
                }

                if (ModelState.IsValid)
                {
                    var taikhoan = _context.Customers.Find(Convert.ToInt32(taikhoanID));
                    if (taikhoan == null)
                    {
                        // Nếu không tìm thấy tài khoản, chuyển hướng đến trang đăng nhập
                        return RedirectToAction("Login", "Accounts");
                    }

                    // Kiểm tra mật khẩu hiện tại
                    string passNow = (model.PasswordNow.Trim() + taikhoan.Salt.Trim()).ToMD5();
                    if (passNow == taikhoan.Password)
                    {
                        // Mật khẩu hiện tại đúng, cập nhật mật khẩu mới
                        string passNew = (model.Password.Trim() + taikhoan.Salt.Trim()).ToMD5();
                        taikhoan.Password = passNew;
                        _context.Update(taikhoan);
                        _context.SaveChanges();

                        _notyfService.Success("Thay đổi mật khẩu thành công!");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        // Mật khẩu hiện tại không đúng
                        ModelState.AddModelError(string.Empty, "Mật khẩu hiện tại không đúng.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log hoặc xử lý lỗi ở đây
                _notyfService.Error("Có lỗi xảy ra khi thay đổi mật khẩu: " + ex.Message);
            }

            // Nếu có lỗi hoặc mật khẩu hiện tại không đúng, chuyển hướng về trang Dashboard
            return RedirectToAction("Dashboard", "Accounts");
        }

    }
}
