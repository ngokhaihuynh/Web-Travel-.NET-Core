#pragma checksum "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a96501d2192285f64461eea4988182441ae95a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a96501d2192285f64461eea4988182441ae95a6", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786989cb0546e35b2b9e683c41e4c1ee30ba28da", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebDuLich.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .booking {\r\n        display: none;\r\n    }\r\n    .carousel {\r\n        display:none;\r\n    }\r\n</style>\r\n\r\n<div class=\"container-fluid py-4\">\r\n    <div class=\"container py-4\">\r\n        <div class=\"row\">\r\n            <div>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                 if (Model != null && Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""cart-container"">
                        <h2 style=""font-weight: 200 !important;"">Giỏ hàng của bạn</h2>
                        <table style=""margin-top: 20px;;"" class=""cart-table"">
                            <thead>
                                <tr>
                                    <th>Tour</th>
                                    <th>Thông tin tour</th>
                                    <th>Đơn giá</th>
                                    <th>Số lượng</th>
                                    <th>Thành tiền</th>
                                    <th>Xóa</th>
                                </tr>
                            </thead>
                            <tbody>
                                <!-- Thêm các dòng cho mỗi tour trong giỏ hàng -->
");
#nullable restore
#line 39 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    foreach (var item in Model)
                                    {
                                        string url = $"/{item.product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1665, "\"", 1676, 1);
#nullable restore
#line 45 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1672, url, 1672, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a96501d2192285f64461eea4988182441ae95a66114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1701, "~/images/products/", 1701, 18, true);
#nullable restore
#line 45 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1719, item.product.Image, 1719, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 45 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1745, item.product.Title, 1745, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n                                            <td><a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 1847, "\"", 1858, 1);
#nullable restore
#line 46 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1854, url, 1854, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                                                              Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td>");
#nullable restore
#line 47 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                           Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                                            <td><input class=\"cartItem\" data-mahh=\"");
#nullable restore
#line 48 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                                                              Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 48 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                                                                                                    Write(item.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2153, "\"", 2173, 1);
#nullable restore
#line 48 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2161, item.amount, 2161, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\"></td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                           Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                                            <td>\r\n                                                <button class=\"removecart\" data-mahh=\"");
#nullable restore
#line 51 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                                                                 Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button>\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </tbody>
                        </table>
                        <div style=""margin-top: 20px;"">

                        </div>
                        <div class=""total"">
                            Tổng tiền: <span style=""font-weight: bold;"" class=""text-primary"">");
#nullable restore
#line 65 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                                                                                        Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</span>
                        </div>
                        <button>
                            <a style=""color: white;"" href=""/"">Quay lại trang chủ</a>
                        </button>
                        <button style=""background-color: var(--primary);"">
");
#nullable restore
#line 71 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"color: white;\" href=\"/checkout.html\">Tiến hành thanh toán</a>\r\n");
#nullable restore
#line 74 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"color: white;\" href=\"/dang-nhap.html?returnUrl=/checkout.html\">Tiến hành thanh toán</a>\r\n");
#nullable restore
#line 78 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </button>\r\n                    </div>\r\n");
#nullable restore
#line 84 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Giỏ hàng trống !</p>\r\n");
#nullable restore
#line 89 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\ShoppingCart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>


        </div>
    </div>
</div>
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

</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            function loadHeaderCart() {
                $(""miniCart"").load(""/AjaxContent/HearderCart"");
                $(""NumberCart"").load(""AjaxContent/NumberCart"");
            }

            $(document).ready(function () {
                $("".removecart"").click(function () {
                    var productid = $(this).attr(""data-mahh"");

                    $.ajax({
                        url: ""api/cart/remove"",
                        type: ""POST"",
                        dataType: ""JSON"",
                        data: {
                            productID: productid
                        },
                        success: function (result) {
                            if (result.success) {
                                loadHeaderCart();
                                alert(""Sản phẩm sẽ được xóa khỏi giỏ hàng!"");
                                location.reload(); // Tải lại trang
                            } else {
                ");
                WriteLiteral(@"                alert(""Có lỗi xảy ra khi xóa sản phẩm khỏi giỏ hàng."");
                            }
                        },
                        error: function () {
                            alert(""Xóa sản phẩm khỏi giỏ hàng thất bại!"");
                        }
                    });
                });
            });


            $("".cartItem"").change(function () {
                // Lấy productID từ thuộc tính data-mahh của phần tử HTML
                var productid = $(this).data(""mahh"");

                // Lấy số lượng từ phần tử HTML
                var soluong = parseInt($(this).val());

                // Gửi yêu cầu AJAX để cập nhật giỏ hàng
                $.ajax({
                    url: ""api/cart/update"", // Đường dẫn tới API cập nhật giỏ hàng
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productID: productid,
                        amount: soluong
                    },
     ");
                WriteLiteral(@"               success: function (result) {
                        if (result.success) {
                            // Nếu cập nhật thành công, cập nhật lại thông tin giỏ hàng trên header và chuyển hướng đến trang giỏ hàng
                            loadHeaderCart();
                            location.reload(); // Tải lại trang
                        } else {
                            // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                            alert(result.message || ""Cập nhật giỏ hàng thất bại."");
                        }
                    },
                    error: function () {
                        // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                        alert(""Cập nhật giỏ hàng thất bại!"");
                    }
                });
            });


        });



    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebDuLich.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
