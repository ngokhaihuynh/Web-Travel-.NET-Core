#pragma checksum "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4518efb5ec1eda5449ffb1443e016b3877ac65a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_IndexBlog), @"mvc.1.0.view", @"/Views/Blog/IndexBlog.cshtml")]
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
#line 1 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4518efb5ec1eda5449ffb1443e016b3877ac65a6", @"/Views/Blog/IndexBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786989cb0546e35b2b9e683c41e4c1ee30ba28da", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_IndexBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.PagedList<WebDuLich.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
  
    ViewData["Title"] = "Blog Index - " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";

    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Blog Start -->
<div class=""container-fluid"">
    <h1 style=""margin-top:50px;display:block; justify-content:center; text-align:center"">Bài viết nổi bật</h1>
    <div class=""container py-5"">
        <div class=""row"">

            <div class=""col-lg-8"">
                <div class=""row pb-3"">
");
#nullable restore
#line 23 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {
                            string url = $"/tintuc/{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 mb-4 pb-2\">\r\n                                <div class=\"blog-item\">\r\n                                    <div class=\"position-relative\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1119, "\"", 1130, 1);
#nullable restore
#line 31 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 1126, url, 1126, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4518efb5ec1eda5449ffb1443e016b3877ac65a65428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1166, "~/images/news/", 1166, 14, true);
#nullable restore
#line 31 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
AddHtmlAttributeValue("", 1180, item.Image, 1180, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
AddHtmlAttributeValue("", 1198, item.Tile, 1198, 10, false);

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
                                        <div class=""blog-date"">
                                            <h6 class=""font-weight-bold mb-n1"">01</h6>
                                            <small class=""text-white text-uppercase"">Jan</small>
                                        </div>
                                    </div>
                                    <div class=""bg-white p-4"">
                                        <div class=""d-flex mb-2"">
                                            <a class=""text-primary text-uppercase text-decoration-none""");
            BeginWriteAttribute("href", " href=\"", 1793, "\"", 1800, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                                                                                           Write(item.CreateDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <span class=\"text-primary px-2\">|</span>\r\n                                            <a class=\"text-primary text-uppercase text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 2039, "\"", 2046, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                                                                                           Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <a class=\"h5 m-0 text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 2192, "\"", 2203, 1);
#nullable restore
#line 43 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 2199, url, 2199, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                                                                      Write(item.Tile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 47 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                        }
                    }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12\">\r\n                        <nav aria-label=\"Page navigation\">\r\n                            <ul class=\"pagination pagination-lg justify-content-center bg-white mb-0\" style=\"padding: 30px;\">\r\n");
#nullable restore
#line 55 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                 if (PageCurrent > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item disabled\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2879, "\"", 2921, 2);
            WriteAttributeValue("", 2886, "/blogs.html?page=", 2886, 17, true);
#nullable restore
#line 58 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 2903, PageCurrent - 1, 2903, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Previous"">
                                            <span aria-hidden=""true"">&laquo;</span>
                                            <span class=""sr-only"">Previous</span>
                                        </a>
                                    </li>
");
#nullable restore
#line 63 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item disabled"">
                                        <a class=""page-link"" href=""/blogs.html"" aria-label=""Previous"">
                                            <span aria-hidden=""true"">&laquo;</span>
                                            <span class=""sr-only"">Previous</span>
                                        </a>
                                    </li>
");
#nullable restore
#line 72 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3860, "\"", 3896, 2);
            WriteAttributeValue("", 3867, "/blogs.html?page=", 3867, 17, true);
#nullable restore
#line 74 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 3884, PageCurrent, 3884, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                                                                                                  Write(PageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3995, "\"", 4028, 2);
            WriteAttributeValue("", 4002, "/blogs.html?page=", 4002, 17, true);
#nullable restore
#line 75 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 4019, PageNext, 4019, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                                                                                        Write(PageNext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\"><a class=\"page-link\" href=\"#\">3</a></li>\r\n                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4258, "\"", 4291, 2);
            WriteAttributeValue("", 4265, "/blogs.html?page=", 4265, 17, true);
#nullable restore
#line 78 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 4282, PageNext, 4282, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                        <span aria-hidden=""true"">&raquo;</span>
                                        <span class=""sr-only"">Next</span>
                                    </a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 mt-5 mt-lg-0"">




                
                <!-- Tag Cloud -->
                <div class=""mb-5"">
                    <h4 class=""text-uppercase mb-4"" style=""letter-spacing: 5px;"">THẺ</h4>
                    <div class=""d-flex flex-wrap m-n1"">
");
#nullable restore
#line 99 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                         if (Model != null && Model.Count() > 0)
                        {
                            foreach (var item in Model)
                            {
                                string url = $"/tintuc/{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 5278, "\"", 5289, 1);
#nullable restore
#line 104 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
WriteAttributeValue("", 5285, url, 5285, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light m-1\">");
#nullable restore
#line 104 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                                                                    Write(item.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 105 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\IndexBlog.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.PagedList<WebDuLich.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
