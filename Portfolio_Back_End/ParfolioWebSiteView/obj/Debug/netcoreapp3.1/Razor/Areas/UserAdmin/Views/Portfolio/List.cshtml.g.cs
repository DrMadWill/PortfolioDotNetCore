#pragma checksum "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102dbabb530c5ced6942b637882ddd2e85fcf81a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserAdmin_Views_Portfolio_List), @"mvc.1.0.view", @"/Areas/UserAdmin/Views/Portfolio/List.cshtml")]
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
#line 1 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using ParfolioWebSiteView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using ParfolioWebSiteView.Areas.Admin.ViewModes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using ParfolioWebSiteView.Areas.UserAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using ParfolioWebSiteView.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using ParfolioWebSiteView.Areas.UserAdmin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102dbabb530c5ced6942b637882ddd2e85fcf81a", @"/Areas/UserAdmin/Views/Portfolio/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4026c6f8c66a10d80ae5e87ad4d2b29fa52d97f6", @"/Areas/UserAdmin/_ViewImports.cshtml")]
    public class Areas_UserAdmin_Views_Portfolio_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Portfolio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminPanelListHeaderLink", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminPanelListScripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
  
    ViewData["Location"] = "Portfolio";
    ViewData["Title"] = "Portfolio List";
 

#line default
#line hidden
#nullable disable
            DefineSection("header_link", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "102dbabb530c5ced6942b637882ddd2e85fcf81a5775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"main-content-inner\">\r\n    <div class=\"row\">\r\n        <!-- Primary table start -->\r\n        <div class=\"col-12  mt-5\">\r\n");
#nullable restore
#line 15 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
             if (TempData["PortfolioAlert"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 mt-2 alert-dismiss\">\r\n                    <div class=\"alert alert-primary alert-dismissible fade show\" role=\"alert\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                   Write(TempData["PortfolioAlert"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                            <span class=\"fa fa-times\"></span>\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card"">
                <div class=""card-body"">
                    <div class=""col-12 mt-2 alert-dismiss"">
                        <div class=""alert alert-warning alert-dismissible fade show"" role=""alert"">
                            Your Portfolio Limit 15!
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span class=""fa fa-times""></span>
                            </button>
                        </div>
                    </div>
                    <div class=""d-flex my-3 justify-content-between"">
                        <h4 class=""header-title"">Portfolio List</h4>
                        <a href=""/UserAdmin/Portfolio/Create"" class=""btn btn-success""><i class=""ti-plus""></i></a>
                    </div>
                    <div class=""data-tables datatable-primary"">
                        <table id=""dataTable2"" class="" w-100 text-center"">
                            <thead clas");
            WriteLiteral(@"s=""text-capitalize"">
                                <tr>
                                    <th>Title </th>
                                    <th>Category</th>
                                    <th>Client</th>
                                    <th>Date</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 52 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                                       Write(item.PortfolioCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 58 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                                       Write(item.PortfolioDetail.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2945, "\"", 2986, 2);
            WriteAttributeValue("", 2952, "/UserAdmin/Portfolio/Show/", 2952, 26, true);
#nullable restore
#line 62 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
WriteAttributeValue("", 2978, item.Id, 2978, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary\"><span class=\"ti-eye\"></span></a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3089, "\"", 3132, 2);
            WriteAttributeValue("", 3096, "/UserAdmin/Portfolio/Update/", 3096, 28, true);
#nullable restore
#line 63 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
WriteAttributeValue("", 3124, item.Id, 3124, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-warning mx-2\"><span class=\"fa fa-edit\"></span></a>\r\n                                            <a onclick=\"return confirm(\'Are You Sure Delete?\')\"");
            BeginWriteAttribute("href", " href=\"", 3293, "\"", 3336, 2);
            WriteAttributeValue("", 3300, "/UserAdmin/Portfolio/Delete/", 3300, 28, true);
#nullable restore
#line 64 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
WriteAttributeValue("", 3328, item.Id, 3328, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"><i class=\"ti-trash\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Primary table end -->\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("footer_link", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "102dbabb530c5ced6942b637882ddd2e85fcf81a14630", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
