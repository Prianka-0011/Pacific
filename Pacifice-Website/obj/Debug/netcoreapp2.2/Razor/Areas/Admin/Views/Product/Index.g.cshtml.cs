#pragma checksum "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a7be4afe33351ffff59591b832f835e42e98baa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\_ViewImports.cshtml"
using Pacifice_Website;

#line default
#line hidden
#line 2 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\_ViewImports.cshtml"
using Pacifice_Website.Models;

#line default
#line hidden
#line 3 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\_ViewImports.cshtml"
using Pacifice_Website.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a7be4afe33351ffff59591b832f835e42e98baa", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce87d28eca0a18bc6060b740b4030e44738a5c09", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pacifice_Website.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px; border-radius:25px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int i = 1;

#line default
#line hidden
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(892, 278, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card mb-4"">
            <div class=""card-header"">
                <span class="" text-warning font-weight-normal""><b>Manage Product </b></span>
            </div>
            <div class=""table-responsive"">
");
            EndContext();
#line 36 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                 if (Model != null)
                {


#line default
#line hidden
            BeginContext(1228, 1198, true);
            WriteLiteral(@"                    <table class="" table border-top-0 table-bordered m-3 table-striped font-weight-normal"">
                        <thead style=""font-size:12px"">
                            <tr>
                                <th>#</th>
                                <th>Category Name</th>
                                <th>Product Name</th>
                                <th>Price</th>
                                <th>Model</th>
                                <th>Grad</th>
                                <th>CarCC</th>
                                <th>Seating</th>
                                <th>Fuel</th>
                                <th>Condition</th>
                                <th>Color</th>
                                
                                <th>Transmission</th>
                                <th>Option</th>
                                <th>Year</th>
                                <th>Image</th>
                                <th>Status</th>
");
            WriteLiteral("                                <th>Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody style=\"font-size:11px\">\r\n");
            EndContext();
#line 63 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2515, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2594, 1, false);
#line 66 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2595, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2643, 18, false);
#line 67 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2661, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2709, 9, false);
#line 68 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2718, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2766, 10, false);
#line 69 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2776, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2824, 10, false);
#line 70 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(2834, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2882, 10, false);
#line 71 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(2892, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2940, 10, false);
#line 72 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.CarCc);

#line default
#line hidden
            EndContext();
            BeginContext(2950, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2998, 12, false);
#line 73 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Seating);

#line default
#line hidden
            EndContext();
            BeginContext(3010, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3058, 9, false);
#line 74 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Fuel);

#line default
#line hidden
            EndContext();
            BeginContext(3067, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3115, 14, false);
#line 75 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Condition);

#line default
#line hidden
            EndContext();
            BeginContext(3129, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3177, 10, false);
#line 76 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Color);

#line default
#line hidden
            EndContext();
            BeginContext(3187, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3235, 17, false);
#line 77 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Transmission);

#line default
#line hidden
            EndContext();
            BeginContext(3252, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3300, 11, false);
#line 78 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Option);

#line default
#line hidden
            EndContext();
            BeginContext(3311, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3359, 9, false);
#line 79 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3368, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3415, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a7be4afe33351ffff59591b832f835e42e98baa12798", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3425, "~/", 3425, 2, true);
#line 80 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 3427, item.Image, 3427, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3494, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 81 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
            BeginContext(3595, 70, true);
            WriteLiteral("                                <td class=\"text-success\">Enable</td>\r\n");
            EndContext();
#line 84 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3785, 71, true);
            WriteLiteral("                                <td class=\"text-warning\">Disable</td>\r\n");
            EndContext();
#line 88 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3895, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3933, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a7be4afe33351ffff59591b832f835e42e98baa15655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 90 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3983, 41, true);
            WriteLiteral("\r\n                                </tr>\r\n");
            EndContext();
#line 92 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                                i++;
                            }

#line default
#line hidden
            BeginContext(4093, 64, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 96 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Product\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4176, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pacifice_Website.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
