#pragma checksum "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bc11415f8fdd04ba1ada0a1db2dee2d1e58943f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserAdmin_Views_Messange_List), @"mvc.1.0.view", @"/Areas/UserAdmin/Views/Messange/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc11415f8fdd04ba1ada0a1db2dee2d1e58943f", @"/Areas/UserAdmin/Views/Messange/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4026c6f8c66a10d80ae5e87ad4d2b29fa52d97f6", @"/Areas/UserAdmin/_ViewImports.cshtml")]
    public class Areas_UserAdmin_Views_Messange_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<MessengeUser>>
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
#line 2 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
  
    ViewData["Location"] = "Messenge Box ";
    ViewData["Title"] = "Messenge List";

#line default
#line hidden
#nullable disable
            DefineSection("header_link", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7bc11415f8fdd04ba1ada0a1db2dee2d1e58943f5772", async() => {
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
            WriteLiteral(@"

<div class=""main-content-inner"">
    <div class=""row"">
        <!-- Primary table start -->
        <div class=""col-12  mt-5"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""header-title"">Messange Box</h4>
                    <div class=""data-tables datatable-primary"">
                        <table id=""dataTable2"" class="" w-100 text-center"">
                            <thead class=""text-capitalize"">
                                <tr>
                                    <th>Full Name</th>
                                    <th>Email</th>
                                    <th>Subject</th>
                                    <th>Read</th>
                                    <th>Send Date</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 32 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 35 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 36 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 38 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                             if (item.Subject.Length > 19)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>  ");
#nullable restore
#line 40 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                                   Write(item.Subject.Substring(0, 18));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</span>\r\n");
#nullable restore
#line 41 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>  ");
#nullable restore
#line 44 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 45 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 49 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                             if (item.IsRead)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"ti-check-box\"></span>\r\n");
#nullable restore
#line 52 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"ti-control-stop\"></span>\r\n");
#nullable restore
#line 56 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                       Write(item.Date.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2734, "\"", 2774, 2);
            WriteAttributeValue("", 2741, "/UserAdmin/Messange/Show/", 2741, 25, true);
#nullable restore
#line 61 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
WriteAttributeValue("", 2766, item.Id, 2766, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary\"><span class=\"ti-eye\"></span></a>\r\n                                            <a onclick=\"return confirm(\'Are You Sure Delete?\')\"");
            BeginWriteAttribute("href", " href=\"", 2926, "\"", 2968, 2);
            WriteAttributeValue("", 2933, "/UserAdmin/Messange/Delete/", 2933, 27, true);
#nullable restore
#line 62 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
WriteAttributeValue("", 2960, item.Id, 2960, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"><i class=\"ti-trash\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Messange\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Primary table end -->\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("footer_link", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7bc11415f8fdd04ba1ada0a1db2dee2d1e58943f14713", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<MessengeUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
