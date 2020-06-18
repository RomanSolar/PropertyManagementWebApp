#pragma checksum "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d3961cd45dc4fc104ee6a2bec6e8b89e1ff515c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Units__UnitAccordion), @"mvc.1.0.view", @"/Views/Units/_UnitAccordion.cshtml")]
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
#line 1 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
using System.Runtime.ExceptionServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
using CSD480Group3Capstone001.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3961cd45dc4fc104ee6a2bec6e8b89e1ff515c", @"/Views/Units/_UnitAccordion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709983a7153eab3563b50021aa9fef6ab9036835", @"/Views/_ViewImports.cshtml")]
    public class Views_Units__UnitAccordion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CSD480Group3Capstone001.Models.Unit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"row accordion mt-2\" id=\"tenantAccordion\">\r\n");
#nullable restore
#line 10 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
          
            int index = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
         foreach (var unit in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-11 ml-auto mr-auto\">\r\n                <div class=\"card-header row border border-dark rounded p-0 mt-2\"");
            BeginWriteAttribute("id", " id=\"", 493, "\"", 529, 1);
#nullable restore
#line 16 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
WriteAttributeValue("", 498, GetAccordionId("header",index), 498, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-12 d-flex\">\r\n                        <div class=\"p-2 text-center\">\r\n                            <span class=\"font-weight-bold p-2\">Unit Number</span>\r\n                            <br />#");
#nullable restore
#line 20 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                              Write(unit.UnitNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-center\">\r\n                            <span class=\"font-weight-bold\">Current Tenant</span>\r\n                            <br />\r\n");
#nullable restore
#line 25 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                              
                                string currTenant = unit.TenantUnits.Where(tu => DateTime.Compare(tu.MovedOutDate, DateTime.Now) > 0).Select(tu => tu.tenant.FirstName + " " + tu.tenant.LastName).FirstOrDefault();
                                if (currTenant != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                               Write(currTenant);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                                               
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>Unoccupied</span>\r\n");
#nullable restore
#line 34 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-center d-none d-sm-block\">\r\n                            <span class=\"font-weight-bold\">Number of Tenants</span>\r\n                            <br />");
#nullable restore
#line 40 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                             Write(unit.TenantUnits.Where(tu => DateTime.Compare(tu.MovedOutDate, DateTime.Now) > 0).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-center d-none d-sm-block\">\r\n                            <span class=\"font-weight-bold\">Square Footage</span>\r\n                            <br />");
#nullable restore
#line 44 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                             Write(unit.SqrFootage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 text-centerd-none d-sm-block\">\r\n                            <span class=\"font-weight-bold\">Building Address</span>\r\n                            <br />");
#nullable restore
#line 48 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                             Write(unit.Building.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"p-2 ml-auto align-self-center\">\r\n                            <button");
            BeginWriteAttribute("id", " id=\"", 2539, "\"", 2576, 1);
#nullable restore
#line 51 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
WriteAttributeValue("", 2544, GetAccordionId("expand", index), 2544, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm border border-dark btn-primary d-inline\" type=\"button\" aria-expanded=\"false\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 51 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                                                                                                                                                                                                     Write(GetAccordionId("body",index));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 51 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                                                                                                                                                                                                                                   Write(GetAccordionId("expand",index));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 51 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                                                                                                                                                                                                                                                                   Write(GetAccordionId("hide",index));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2798, "\"", 2843, 1);
#nullable restore
#line 51 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
WriteAttributeValue("", 2814, GetAccordionId("body",index), 2814, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Expand</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 2966, "\"", 3000, 1);
#nullable restore
#line 55 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
WriteAttributeValue("", 2971, GetAccordionId("body",index), 2971, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3018, "\"", 3067, 1);
#nullable restore
#line 55 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
WriteAttributeValue("", 3036, GetAccordionId("header",index), 3036, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#tenantAccordion\">\r\n                    <div class=\"card-body\">\r\n                        ");
#nullable restore
#line 57 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
                   Write(await Html.PartialAsync("~/Views/Units/_DisplayUnit.cshtml", unit, new ViewDataDictionary(ViewData)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 61 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
            index++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Units\_UnitAccordion.cshtml"
           
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CSD480Group3Capstone001.Models.Unit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
