#pragma checksum "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c9b05d7b4a08f2bcd971c74c844dc309a34576"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c9b05d7b4a08f2bcd971c74c844dc309a34576", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce87d28eca0a18bc6060b740b4030e44738a5c09", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pacifice_Website.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int i = 1;

#line default
#line hidden
            BeginContext(111, 721, true);
            WriteLiteral(@"
<div class=""border p-4 rounded"">
    <h1 class=""text-center text-warning mb-5"">All Category </h1>
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""form-group"">
                        <input class=""form-control"" name=""srcText"" value="""" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <button class=""btn btn-info"" type=""submit"">Search</button>
                    </div>
                </div>

            </div>
        </div>
        <div class=""col-md-4 pull-right"">
            ");
            EndContext();
            BeginContext(832, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c9b05d7b4a08f2bcd971c74c844dc309a345765579", async() => {
                BeginContext(879, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(893, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(955, 222, true);
            WriteLiteral("        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th>#</th>\r\n                    <th>Name</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1242, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1289, 1, false);
#line 42 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 51, true);
            WriteLiteral("</td>\r\n                    <td style=\"width:200px\">");
            EndContext();
            BeginContext(1342, 9, false);
#line 43 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1351, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                     if (item.Status)
                    {

#line default
#line hidden
            BeginContext(1420, 77, true);
            WriteLiteral("                        <td style=\"width:200px;color:darkgreen\">Enable</td>\r\n");
            EndContext();
#line 47 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1569, 75, true);
            WriteLiteral("                        <td style=\"width:200px;color:maroon\">Disable</td>\r\n");
            EndContext();
#line 51 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1667, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1689, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97c9b05d7b4a08f2bcd971c74c844dc309a345769802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 53 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
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
            BeginContext(1739, 25, true);
            WriteLiteral("\r\n                </tr>\r\n");
            EndContext();
#line 55 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
                    i++;
                }

#line default
#line hidden
            BeginContext(1809, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 59 "C:\Users\niku\source\repos\Pacifice-Website\Pacifice-Website\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1856, 34, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<h1>Index</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pacifice_Website.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591