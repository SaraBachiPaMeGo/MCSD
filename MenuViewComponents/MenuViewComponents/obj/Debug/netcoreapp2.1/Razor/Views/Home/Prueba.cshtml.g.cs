#pragma checksum "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "909f75c29f1153c5424d899423a1ff7be132a3fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Prueba), @"mvc.1.0.view", @"/Views/Home/Prueba.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Prueba.cshtml", typeof(AspNetCore.Views_Home_Prueba))]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\_ViewImports.cshtml"
using MenuViewComponents;

#line default
#line hidden
#line 2 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\_ViewImports.cshtml"
using MenuViewComponents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909f75c29f1153c5424d899423a1ff7be132a3fc", @"/Views/Home/Prueba.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608cae10fd6c7baaef72df6d47229dff1f0faa95", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Prueba : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuViewComponents.Models.Departamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
  
    ViewData["Title"] = "Prueba";

#line default
#line hidden
            BeginContext(104, 30, true);
            WriteLiteral("\r\n<h2>Prueba</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(134, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6662606a81074fb3b09abac30e79217b", async() => {
                BeginContext(157, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(171, 121, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(293, 43, false);
#line 16 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.DisplayNameFor(model => model.Dept_no));

#line default
#line hidden
            EndContext();
            BeginContext(336, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(392, 43, false);
#line 19 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.DisplayNameFor(model => model.DNombre));

#line default
#line hidden
            EndContext();
            BeginContext(435, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(491, 39, false);
#line 22 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.DisplayNameFor(model => model.Loc));

#line default
#line hidden
            EndContext();
            BeginContext(530, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(648, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(697, 42, false);
#line 31 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dept_no));

#line default
#line hidden
            EndContext();
            BeginContext(739, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(795, 42, false);
#line 34 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.DisplayFor(modelItem => item.DNombre));

#line default
#line hidden
            EndContext();
            BeginContext(837, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(893, 38, false);
#line 37 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loc));

#line default
#line hidden
            EndContext();
            BeginContext(931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(987, 65, false);
#line 40 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1073, 71, false);
#line 41 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1165, 69, false);
#line 42 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Home\Prueba.cshtml"
}

#line default
#line hidden
            BeginContext(1273, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuViewComponents.Models.Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
