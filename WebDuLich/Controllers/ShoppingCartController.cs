using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Extension;
using WebDuLich.Models;
using WebDuLich.ModelViews;

namespace WebDuLich.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly QLDLContext _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(QLDLContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // định nghĩa giỏ hàng
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if(gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }

                return gh;
            }
        }


        // thêm mới sản phẩm vào giỏ hàng
        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            List<CartItem> gioHang = GioHang;

            try
            {
                // them san pham vao gio hang
                CartItem item = GioHang.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null) // da co => cap nhat
                {
                    if (amount.HasValue)
                    {
                        item.amount = amount.Value;
                    }
                    else
                    {
                        item.amount++;
                    }
                }
                else
                {
                    Product hh = _context.Products.SingleOrDefault(p => p.ProductId == productID);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = hh

                    };
                    gioHang.Add(item); // them vao gio
                }
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                _notyfService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
            
        }

        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            try
            {
                // Lấy giỏ hàng từ session
                var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");

                // Kiểm tra xem giỏ hàng có tồn tại không
                if (cart == null)
                {
                    return Json(new { success = false, message = "Không tìm thấy giỏ hàng." });
                }

                // Tìm sản phẩm trong giỏ hàng
                var item = cart.SingleOrDefault(p => p.product.ProductId == productID);

                // Kiểm tra xem sản phẩm có tồn tại trong giỏ hàng không
                if (item == null)
                {
                    return Json(new { success = false, message = "Không tìm thấy sản phẩm trong giỏ hàng." });
                }

                // Kiểm tra số lượng mới có hợp lệ không
                if (!amount.HasValue || amount.Value < 1)
                {
                    return Json(new { success = false, message = "Số lượng sản phẩm không hợp lệ." });
                }

                // Cập nhật số lượng sản phẩm
                item.amount = amount.Value;

                // Lưu lại giỏ hàng vào session
                HttpContext.Session.Set<List<CartItem>>("GioHang", cart);

                // Trả về kết quả thành công
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần)
                return Json(new { success = false, message = "Đã xảy ra lỗi khi cập nhật giỏ hàng: " + ex.Message });
            }
        }



        [HttpPost]
        [Route("api/cart/remove")]
        public ActionResult Remove(int productID)
        {

            try
            {
                List<CartItem> gioHang = GioHang;
                CartItem item = gioHang.SingleOrDefault(P => P.product.ProductId == productID);
                if (item != null)
                {
                    gioHang.Remove(item);
                }
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
           
        }

        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {
            return View(GioHang);

           
           
        }
    }
}
