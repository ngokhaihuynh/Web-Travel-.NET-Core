#pragma checksum "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2624233137bee059ffffe7e908ac1ae0a074828d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2624233137bee059ffffe7e908ac1ae0a074828d", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786989cb0546e35b2b9e683c41e4c1ee30ba28da", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.PagedList<WebDuLich.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "newest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "oldest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
   
    Category category = ViewBag.CurrentCat;
    //ViewData["Title"] = category.Title+ " " + ViewBag.CurrentPage;
    //Layout = "~/Views/Shared/_Layout.cshtml";

    //int PageCurrent = ViewBag.CurrentPage;
    //int PageNext = PageCurrent + 1;


    ViewData["Title"] = "Sản phẩm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"margin-top:50px\" class=\"container-fluid\">\r\n    <div class=\"container pb-3\">\r\n        <div class=\"text-center mb-3 pb-3\">\r\n\r\n            <h1>");
#nullable restore
#line 23 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
           Write(category.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"w-25\">\r\n                <h4");
            BeginWriteAttribute("style", " style=\"", 768, "\"", 776, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-primary"">Danh mục</h4>
                <ul style=""list-style: none; padding: 0; margin-top: 20px;"">
                    <li class=""fz-18 "">
                        <a class=""text-dark"" href=""/"">Trang chủ</a>
                    </li>
                    <li class=""fz-18""><a class=""text-dark""");
            BeginWriteAttribute("href", " href=\"", 1087, "\"", 1094, 0);
            EndWriteAttribute();
            WriteLiteral(">Về chúng tôi</a></li>\r\n                    <li class=\"fz-18\"><a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1177, "\"", 1184, 0);
            EndWriteAttribute();
            WriteLiteral(">Dịch vụ</a></li>\r\n                    <li class=\"fz-18\"><a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1262, "\"", 1269, 0);
            EndWriteAttribute();
            WriteLiteral(">Bài viết</a></li>\r\n                    <li class=\"fz-18\"><a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1348, "\"", 1355, 0);
            EndWriteAttribute();
            WriteLiteral(@">Liên hệ</a></li>
                </ul>
            </div>
            <div class="" w-75 "">
                <div style=""justify-content: space-between;"" class=""dp-flex"">
                    <h4>Tour nổi bật</h4>
                    <div>
                        <span>Sắp sếp theo:</span>
                        <select name=""sort-by"" id=""sort-by"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2624233137bee059ffffe7e908ac1ae0a074828d7713", async() => {
                WriteLiteral("Theo Tên A -> Z");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2624233137bee059ffffe7e908ac1ae0a074828d8909", async() => {
                WriteLiteral("Theo Giá");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2624233137bee059ffffe7e908ac1ae0a074828d10098", async() => {
                WriteLiteral("Mới Nhất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2624233137bee059ffffe7e908ac1ae0a074828d11288", async() => {
                WriteLiteral("Cũ Nhất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n                <div style=\"margin-top: 20px;\" class=\"row dp-flex\">\r\n");
#nullable restore
#line 52 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {
                            string url = $"/{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                                <div class=\"package-item bg-white mb-2\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2566, "\"", 2577, 1);
#nullable restore
#line 59 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
WriteAttributeValue("", 2573, url, 2573, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2624233137bee059ffffe7e908ac1ae0a074828d13584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2607, "~/images/products/", 2607, 18, true);
#nullable restore
#line 59 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 2625, item.Image, 2625, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 2643, item.Image, 2643, 11, false);

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
            WriteLiteral(@"</a>
                                    <div class=""p-4"">
                                        <div class=""d-flex justify-content-between mb-3"">
                                            <small class=""m-0""><i class=""fa fa-map-marker-alt text-primary mr-2""></i>");
#nullable restore
#line 62 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
                                                                                                                Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                          
                                            <small class=""m-0""><i class=""fa fa-user text-primary mr-2""></i>2 người</small>
                                        </div>
                                        <a class=""h5 text-decoration-none""");
            BeginWriteAttribute("href", " href=\"", 3238, "\"", 3249, 1);
#nullable restore
#line 66 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
WriteAttributeValue("", 3245, url, 3245, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
                                                                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        <div class=""border-top mt-4 pt-4"">
                                            <div class=""d-flex justify-content-between"">
                                               
                                                <h5 class=""m-0""> ");
#nullable restore
#line 70 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
                                                            Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</h5>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Product\List.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n");
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<style>\r\n    .booking {\r\n        display: none;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.PagedList<WebDuLich.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591