#pragma checksum "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\AdminCategories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "438f4793ad4fc1512ccb8d18ff8265a231017a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCategories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCategories/Details.cshtml")]
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
#line 1 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\_ViewImports.cshtml"
using WebDuLich;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\_ViewImports.cshtml"
using WebDuLich.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"438f4793ad4fc1512ccb8d18ff8265a231017a2a", @"/Areas/Admin/Views/AdminCategories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70a836c66b50282852727875ef1a4c7ed2c1e4e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminCategories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDuLich.Models.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\AdminCategories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<div style=""margin-left:30px;"">
    <h1 style=""font-weight:500;"">Chi tiết danh mục</h1>

    <div>
        
        <hr />
        <dl class=""row"">
            <dt class=""col-sm-2"">
                Tên danh mục:
            </dt>
            <dd class=""col-sm-10"">
                ");
#nullable restore
#line 20 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\AdminCategories\Details.cshtml"
           Write(Html.DisplayFor(model => model.CatName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Trạng thái:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 50 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\AdminCategories\Details.cshtml"
           Write(Html.DisplayFor(model => model.Publish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
            WriteLiteral("        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "438f4793ad4fc1512ccb8d18ff8265a231017a2a5413", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\ngokh\Desktop\WebDuLich_DaHoaThanh\WebDuLich\Areas\Admin\Views\AdminCategories\Details.cshtml"
                               WriteLiteral(Model.CatId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "438f4793ad4fc1512ccb8d18ff8265a231017a2a7588", async() => {
                WriteLiteral("Quay lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<style>\r\n    dd {\r\n        border: 1px solid #808080;\r\n        width: 90%;\r\n    }\r\n\r\n    dt {\r\n        margin-top: 20px;\r\n        line-height: 30px;\r\n        font-weight: bold;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDuLich.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
