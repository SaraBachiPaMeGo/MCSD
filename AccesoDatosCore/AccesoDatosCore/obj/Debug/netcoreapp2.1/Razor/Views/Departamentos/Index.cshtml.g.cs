#pragma checksum "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10fd9cbece067990be268a5f9b02b1d75254f4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Index), @"mvc.1.0.view", @"/Views/Departamentos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departamentos/Index.cshtml", typeof(AspNetCore.Views_Departamentos_Index))]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\_ViewImports.cshtml"
using AccesoDatosCore;

#line default
#line hidden
#line 2 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\_ViewImports.cshtml"
using AccesoDatosCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10fd9cbece067990be268a5f9b02b1d75254f4b6", @"/Views/Departamentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46994007bd5b35ac7859d0e8ee69edfe2467f9b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccesoDatosCore.Models.Departamento>>
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f9b2fb235e240cdb33ac8f69effaabb", async() => {
                BeginContext(152, 10, true);
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
            BeginContext(166, 121, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(288, 43, false);
#line 16 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dept_no));

#line default
#line hidden
            EndContext();
            BeginContext(331, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(387, 43, false);
#line 19 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DNombre));

#line default
#line hidden
            EndContext();
            BeginContext(430, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(486, 39, false);
#line 22 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Loc));

#line default
#line hidden
            EndContext();
            BeginContext(525, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(643, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(692, 42, false);
#line 31 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dept_no));

#line default
#line hidden
            EndContext();
            BeginContext(734, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(790, 42, false);
#line 34 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DNombre));

#line default
#line hidden
            EndContext();
            BeginContext(832, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(888, 38, false);
#line 37 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loc));

#line default
#line hidden
            EndContext();
            BeginContext(926, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(982, 65, false);
#line 40 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1068, 71, false);
#line 41 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1160, 69, false);
#line 42 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\AlumnoMCSD\source\repos\AccesoDatosCore\AccesoDatosCore\Views\Departamentos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1268, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccesoDatosCore.Models.Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
