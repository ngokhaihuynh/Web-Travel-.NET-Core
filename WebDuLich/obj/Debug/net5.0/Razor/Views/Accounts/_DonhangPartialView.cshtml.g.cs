#pragma checksum "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb7d8f3d28e5608e15bffe14c14f6dd1c64f87ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts__DonhangPartialView), @"mvc.1.0.view", @"/Views/Accounts/_DonhangPartialView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\_ViewImports.cshtml"
using WebDuLich;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\_ViewImports.cshtml"
using WebDuLich.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7d8f3d28e5608e15bffe14c14f6dd1c64f87ac", @"/Views/Accounts/_DonhangPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786989cb0546e35b2b9e683c41e4c1ee30ba28da", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts__DonhangPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""width:100%"">
        <div class=""cart-container"">
            <h2 style=""font-weight: 200 !important;"">Giỏ hàng của bạn</h2>
            <table style=""margin-top: 20px;"" class=""cart-table"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Ngày đặt tour</th>
                        <th>Ngày đi:</th>
                        <th>Trạng thái đơn hàng</th>
                        <th>Thành tiền</th>
                        <th>Xóa</th>
                    </tr>
                </thead>
              
                <tbody>
");
#nullable restore
#line 20 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        \r\n                        <td>");
#nullable restore
#line 24 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.NgayDi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.Transact.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                        <td><button onclick=\"removeTour(this)\">Xóa</button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Thêm các dòng cho mỗi tour trong giỏ hàng -->


                </tbody>
            </table>
            <div style=""margin-top: 20px;"">

            </div>
            
            <button>
                <a style=""color: white;"" href=""/"">Quay lại trang chủ</a>
            </button>
           
        </div>
    </div>
");
#nullable restore
#line 47 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Chưa có đơn hàng !</p>\r\n");
#nullable restore
#line 51 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Accounts\_DonhangPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>
    //   Xóa tour
    function removeTour(button) {
        var row = button.parentNode.parentNode;
        row.parentNode.removeChild(row);
        updateTotal();
    }

    // Cập nhật tông tiền
    function updateTotal() {
        var totalPrice = 0;
        var rows = document.querySelectorAll('.cart-table tbody tr');
        rows.forEach(function (row) {
            var price = parseFloat(row.cells[2].textContent.replace('$', ''));
            var quantity = parseInt(row.cells[3].querySelector('input').value);
            var subtotal = price * quantity;
            row.cells[4].textContent = '$' + subtotal.toFixed(2);
            totalPrice += subtotal;
        });
        document.querySelector('.total').textContent = 'Tổng tiền: $' + totalPrice.toFixed(2);
    }

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591