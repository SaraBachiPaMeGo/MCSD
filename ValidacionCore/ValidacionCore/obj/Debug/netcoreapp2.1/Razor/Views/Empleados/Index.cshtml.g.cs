#pragma checksum "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38dea728f8196aa1be49c70e2dde8a9d288d4c39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Index), @"mvc.1.0.view", @"/Views/Empleados/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Index.cshtml", typeof(AspNetCore.Views_Empleados_Index))]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\_ViewImports.cshtml"
using ValidacionCore;

#line default
#line hidden
#line 2 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\_ViewImports.cshtml"
using ValidacionCore.Models;

#line default
#line hidden
#line 3 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38dea728f8196aa1be49c70e2dde8a9d288d4c39", @"/Views/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f138fcbaa2440be609a8b58b702a42757a2216", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ValidacionCore.Models.Empleados>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348b774b874c4ebab08abd91da611e9c", async() => {
                BeginContext(148, 10, true);
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
            BeginContext(162, 121, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(284, 42, false);
#line 16 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Emp_no));

#line default
#line hidden
            EndContext();
            BeginContext(326, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(382, 42, false);
#line 19 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(424, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(480, 42, false);
#line 22 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Oficio));

#line default
#line hidden
            EndContext();
            BeginContext(522, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(578, 43, false);
#line 25 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(677, 39, false);
#line 28 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dir));

#line default
#line hidden
            EndContext();
            BeginContext(716, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(811, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(860, 41, false);
#line 36 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Emp_no));

#line default
#line hidden
            EndContext();
            BeginContext(901, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(957, 41, false);
#line 39 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1054, 41, false);
#line 42 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Oficio));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1153, 38, false);
#line 46 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dir));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\AlumnoMCSD\source\repos\ValidacionCore\ValidacionCore\Views\Empleados\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1232, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ValidacionCore.Models.Empleados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
