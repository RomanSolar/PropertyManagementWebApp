#pragma checksum "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad01a6a54197775f1bd43565a3cfa8077c472b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants__tenantAccordion), @"mvc.1.0.view", @"/Views/Tenants/_tenantAccordion.cshtml")]
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
#nullable restore
#line 1 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
using CSD480Group3Capstone001.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad01a6a54197775f1bd43565a3cfa8077c472b5", @"/Views/Tenants/_tenantAccordion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709983a7153eab3563b50021aa9fef6ab9036835", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants__tenantAccordion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CSD480Group3Capstone001.Models.Tenant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"row accordion mt-2\" id=\"tenantAccordion\">\r\n");
#nullable restore
#line 9 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
          
            int index = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
         foreach (var tenant in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-11 ml-auto mr-auto\">\r\n                <div class=\"card-header row border border-dark rounded p-0 mt-2\"");
            BeginWriteAttribute("id", " id=\"", 456, "\"", 492, 1);
#nullable restore
#line 15 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
WriteAttributeValue("", 461, GetAccordionId("header",index), 461, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-12 d-flex\">\r\n                        <div class=\"p-2 text-center\">\r\n                            <span class=\"font-weight-bold\">Tenant Name</span>\r\n                            <br />");
#nullable restore
#line 19 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                             Write(tenant.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                                               Write(tenant.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-center d-none d-sm-block\">\r\n                            <span class=\"font-weight-bold\">Move In Date</span>\r\n                            <br />");
#nullable restore
#line 23 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                             Write(tenant.TenantUnits.OrderByDescending(tu => tu.MovedOutDate).Select(tu => tu.MovedInDate).First().Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-center\">\r\n                            <span class=\"font-weight-bold\">Phone Number</span>\r\n                            <br />");
#nullable restore
#line 27 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                             Write(tenant.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-center d-none d-sm-block\">\r\n                            <span class=\"font-weight-bold\">Move Out Date</span>\r\n                            <br />");
#nullable restore
#line 31 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                             Write(tenant.TenantUnits.OrderByDescending(tu => tu.MovedOutDate).Select(tu => tu.MovedOutDate).First().Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 ml-auto align-self-center\">\r\n                            <button");
            BeginWriteAttribute("id", " id=\"", 1801, "\"", 1837, 1);
#nullable restore
#line 34 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
WriteAttributeValue("", 1806, GetAccordionId("expand",index), 1806, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm border border-dark btn-primary d-inline\" type=\"button\" aria-expanded=\"false\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 34 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                                                                                                                                                                                                    Write(GetAccordionId("body",index));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 34 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                                                                                                                                                                                                                                  Write(GetAccordionId("expand",index));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 34 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                                                                                                                                                                                                                                                                  Write(GetAccordionId("hide",index));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2059, "\"", 2104, 1);
#nullable restore
#line 34 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
WriteAttributeValue("", 2075, GetAccordionId("body",index), 2075, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Expand</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 2227, "\"", 2261, 1);
#nullable restore
#line 38 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
WriteAttributeValue("", 2232, GetAccordionId("body",index), 2232, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2279, "\"", 2328, 1);
#nullable restore
#line 38 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
WriteAttributeValue("", 2297, GetAccordionId("header",index), 2297, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#tenantAccordion\">\r\n                    <div class=\"card-body\">\r\n                        ");
#nullable restore
#line 40 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
                   Write(await Html.PartialAsync("~/Views/Tenants/_DisplayTenant.cshtml", tenant,new ViewDataDictionary(ViewData)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
            index++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Tenants\_tenantAccordion.cshtml"
           
    private string GetAccordionId(string str,int num)
    {
        return str + num.ToString();
    }

    private void DisplaySearchedCat()
    {
        List<string> searchAreas = (List<string>)ViewData["searchAreas"];
        string searchBy = (string)ViewData["searchBy"];

        if (!string.IsNullOrEmpty(searchBy))
        {
            if (!searchBy.Equals(searchAreas[0]))//Do nothing Name is always displayed
            {
                

            }else if (searchBy.Equals(searchAreas[1]))//License Plate
            {

            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CSD480Group3Capstone001.Models.Tenant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
