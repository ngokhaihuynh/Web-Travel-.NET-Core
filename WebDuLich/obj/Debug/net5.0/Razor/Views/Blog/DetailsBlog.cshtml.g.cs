#pragma checksum "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0822e1c0a34cba884cd7e7df40048c1fc61af80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_DetailsBlog), @"mvc.1.0.view", @"/Views/Blog/DetailsBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0822e1c0a34cba884cd7e7df40048c1fc61af80", @"/Views/Blog/DetailsBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786989cb0546e35b2b9e683c41e4c1ee30ba28da", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_DetailsBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDuLich.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px; height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
  
    ViewData["Title"] = Model.Tile;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/tintuc/{Model.PostId}.html";
    List<News> Baivietlienquan = ViewBag.lsBaiVietLienQuan;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .booking {
        display: none;
    }

    .carousel {
        display: none;
    }
    .page-header {
        display:none
    }
    img {
        width: 100%;
        vertical-align: middle;
        border-style: none;
    }
</style>
<!-- Blog Start -->
<div style=""margin-top:50px"" class=""container-fluid"">
    <div class=""container"">
        
        <div class=""row"">
            <div class=""col-lg-8"">
                
                <!-- Blog Detail Start -->
                <div class=""pb-3"">
                 
                    <div class=""blog-item"">
                        <div class=""position-relative"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0822e1c0a34cba884cd7e7df40048c1fc61af805303", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 962, "~/images/news/", 962, 14, true);
#nullable restore
#line 39 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
AddHtmlAttributeValue("", 976, Model.Image, 976, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
AddHtmlAttributeValue("", 995, Model.Tile, 995, 11, false);

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
            WriteLiteral(@"

                        </div>
                    </div>
                    <div class=""bg-white mb-3"" style=""padding: 30px;"">
                        <div class=""d-flex mb-3"">
                            <a class=""text-primary text-uppercase text-decoration-none""");
            BeginWriteAttribute("href", " href=\"", 1282, "\"", 1289, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                                                                           Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"text-primary px-2\">|</span>\r\n                            <a class=\"text-primary text-uppercase text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 1471, "\"", 1478, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                                                                           Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                        <h1 class=\"mb-3\">");
#nullable restore
#line 49 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                    Write(Model.Tile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h4 class=\"mb-3\">");
#nullable restore
#line 50 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                    Write(Model.ShortContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                        ");
#nullable restore
#line 52 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                   Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <!-- Blog Detail End -->
             
            </div>

            <div class=""col-lg-4 mt-5 mt-lg-0"">


                <!-- Search Form -->
                


                <!-- bài viết liên quan Recent Post -->
                <div class=""mb-5"">
                    <h4 class=""text-uppercase mb-4"" style=""letter-spacing: 5px;"">Bài viết liên quan</h4>
");
#nullable restore
#line 69 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                     if (Baivietlienquan != null && Baivietlienquan.Count() > 0)
                    {
                        foreach (var item in Baivietlienquan)
                        {
                            string _url = $"/tintuc/{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"d-flex align-items-center text-decoration-none bg-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2521, "\"", 2533, 1);
#nullable restore
#line 74 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
WriteAttributeValue("", 2528, _url, 2528, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0822e1c0a34cba884cd7e7df40048c1fc61af8011038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2631, "~/images/news/", 2631, 14, true);
#nullable restore
#line 75 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
AddHtmlAttributeValue("", 2645, item.Image, 2645, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 75 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
AddHtmlAttributeValue("", 2663, item.Tile, 2663, 10, false);

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
            WriteLiteral("\r\n                                <div class=\"pl-3\">\r\n                                    <h6 class=\"m-1\">");
#nullable restore
#line 77 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                               Write(item.Tile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <small>");
#nullable restore
#line 78 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                      Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </a>\r\n");
#nullable restore
#line 81 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>

                <!-- Tag Cloud -->
                <div class=""mb-5"">
                    <h4 class=""text-uppercase mb-4"" style=""letter-spacing: 5px;"">THẺ</h4>
                    <div class=""d-flex flex-wrap m-n1"">
                      
                        <a");
            BeginWriteAttribute("href", " href=\"", 3291, "\"", 3298, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light m-1\">");
#nullable restore
#line 92 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Views\Blog\DetailsBlog.cshtml"
                                                        Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDuLich.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591