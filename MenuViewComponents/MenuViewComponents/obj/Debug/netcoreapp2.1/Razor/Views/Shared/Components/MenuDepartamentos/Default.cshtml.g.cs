#pragma checksum "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Shared\Components\MenuDepartamentos\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4b6b77452fcdb240c1dfe6377ddd6a374c9c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuDepartamentos_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MenuDepartamentos/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MenuDepartamentos/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MenuDepartamentos_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4b6b77452fcdb240c1dfe6377ddd6a374c9c7d", @"/Views/Shared/Components/MenuDepartamentos/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608cae10fd6c7baaef72df6d47229dff1f0faa95", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuDepartamentos_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuViewComponents.Models.Departamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Shared\Components\MenuDepartamentos\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(103, 42, true);
            WriteLiteral("\r\n<h2>Render Partial Core</h2>\r\n\r\n\r\n<ul>\r\n");
            EndContext();
#line 10 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Shared\Components\MenuDepartamentos\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(186, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(213, 42, false);
#line 13 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Shared\Components\MenuDepartamentos\Default.cshtml"
       Write(Html.DisplayFor(modelItem => item.DNombre));

#line default
#line hidden
            EndContext();
            BeginContext(255, 42, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n           ");
            EndContext();
            BeginContext(297, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecc3a24fac4a4c5eb56fdcb2226b5312", async() => {
                BeginContext(377, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDept", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Shared\Components\MenuDepartamentos\Default.cshtml"
                                                                WriteLiteral(item.Dept_no);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDept"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDept", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDept"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(389, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 18 "C:\Users\AlumnoMCSD\source\repos\MenuViewComponents\MenuViewComponents\Views\Shared\Components\MenuDepartamentos\Default.cshtml"

    }

#line default
#line hidden
            BeginContext(415, 5, true);
            WriteLiteral("</ul>");
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