#pragma checksum "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047b2f65a8cc09acfa0142e828ad4ee3deaca8c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_display), @"mvc.1.0.view", @"/Views/Home/display.cshtml")]
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
#line 1 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\_ViewImports.cshtml"
using CSD480Group3Capstone001;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\_ViewImports.cshtml"
using CSD480Group3Capstone001.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047b2f65a8cc09acfa0142e828ad4ee3deaca8c4", @"/Views/Home/display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709983a7153eab3563b50021aa9fef6ab9036835", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSD480Group3Capstone001.Models.UserTabViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Tenant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SwitchToTabs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Building", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<h2> Admin View</h2>\r\n<ul class=\"nav nav-tabs\">\r\n    <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 238, "\"", 335, 1);
#nullable restore
#line 11 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
WriteAttributeValue("", 246, Model.ActiveTab == CSD480Group3Capstone001.Models.Tab.Tenant ? "active": string.Empty , 246, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "047b2f65a8cc09acfa0142e828ad4ee3deaca8c45515", async() => {
                WriteLiteral("Tenant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 436, "\"", 535, 1);
#nullable restore
#line 12 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
WriteAttributeValue("", 444, Model.ActiveTab == CSD480Group3Capstone001.Models.Tab.Building ? "active": string.Empty , 444, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "047b2f65a8cc09acfa0142e828ad4ee3deaca8c47663", async() => {
                WriteLiteral("Building");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 640, "\"", 737, 1);
#nullable restore
#line 13 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
WriteAttributeValue("", 648, Model.ActiveTab == CSD480Group3Capstone001.Models.Tab.Tenant ? "active": string.Empty , 648, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "047b2f65a8cc09acfa0142e828ad4ee3deaca8c49811", async() => {
                WriteLiteral("Vehicle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n</ul>\r\n\r\n");
#nullable restore
#line 16 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
 switch (Model.ActiveTab)
{
    case CSD480Group3Capstone001.Models.Tab.Tenant:
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
   Write(await Component.InvokeAsync("Tenant"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
                                              ;
        break;

    case CSD480Group3Capstone001.Models.Tab.Building:
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
   Write(await Component.InvokeAsync("Building"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
                                                ;
        break;

    case CSD480Group3Capstone001.Models.Tab.Vehicle:
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
   Write(await Component.InvokeAsync("Vehicle"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Home\display.cshtml"
                                               ;
        break;

    default:
        break;

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSD480Group3Capstone001.Models.UserTabViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
