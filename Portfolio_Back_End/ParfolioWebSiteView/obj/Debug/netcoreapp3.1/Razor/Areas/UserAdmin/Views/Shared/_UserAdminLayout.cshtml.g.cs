#pragma checksum "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c49f8d85c5be9dc11b29009bbd18eac8fe725c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserAdmin_Views_Shared__UserAdminLayout), @"mvc.1.0.view", @"/Areas/UserAdmin/Views/Shared/_UserAdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c49f8d85c5be9dc11b29009bbd18eac8fe725c0", @"/Areas/UserAdmin/Views/Shared/_UserAdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4026c6f8c66a10d80ae5e87ad4d2b29fa52d97f6", @"/Areas/UserAdmin/_ViewImports.cshtml")]
    public class Areas_UserAdmin_Views_Shared__UserAdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/uversalfilo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("apple-touch-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/assets/images/icon/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Profile/profil.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar user-thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
  
    User user = null;
    if (User.Identity.IsAuthenticated)
    {
        user = userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
  
    List<MessengeUser> messenge = dbContext.MessengeUsers.Where(dr => dr.User.UserName == User.Identity.Name && dr.IsRead == false).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html class=\"no-js\" lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c09188", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <title>");
#nullable restore
#line 22 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c09940", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
Write(RenderSection("header_link", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c011829", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c013717", async() => {
                WriteLiteral(@"
    <!--[if lt IE 8]>
            <p class=""browserupgrade"">You are using an <strong>outdated</strong> browser. Please <a href=""http://browsehappy.com/"">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
    <!-- preloader area start -->
    <div id=""preloader"">
        <div class=""loader""></div>
    </div>
    <!-- preloader area end -->
    <!-- page container area start -->
    <div class=""page-container"">
        <!-- sidebar menu area start -->
        <div class=""sidebar-menu"">
            <div class=""sidebar-header"">
                <div class=""logo"">
                    <a href=""/UserAdmin"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c014640", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"main-menu\">\r\n                <div class=\"menu-inner\">\r\n                    <nav>\r\n                        <ul class=\"metismenu\" id=\"menu\">\r\n\r\n                            ");
#nullable restore
#line 55 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                       Write(await Component.InvokeAsync("SideBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"

                        </ul>
                    </nav>
                </div>
            </div>
        </div>
        <!-- sidebar menu area end -->
        <!-- main content area start -->
        <div class=""main-content"">
            <!-- header area start -->
            <div class=""header-area"">
                <div class=""row align-items-center"">
                    <!-- nav and search button -->
                    <div class=""col-md-6 col-sm-8 clearfix"">
                        <div class=""nav-btn pull-left"">
                            <span></span>
                            <span></span>
                            <span></span>
                        </div>
");
                WriteLiteral(@"                    </div>
                    <!-- profile info & task notification -->
                    <div class=""col-md-6 col-sm-4 clearfix"">
                        <ul class=""notification-area pull-right"">
                            <li id=""full-view""><i class=""ti-fullscreen""></i></li>
                            <li id=""full-view-exit""><i class=""ti-zoom-out""></i></li>
");
                WriteLiteral("                            <li class=\"dropdown\">\r\n                                <i class=\"fa fa-envelope-o dropdown-toggle\" data-toggle=\"dropdown\"><span>");
#nullable restore
#line 200 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                                                                    Write(messenge.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></i>\r\n                                <div class=\"dropdown-menu notify-box nt-enveloper-box\">\r\n                                    <span class=\"notify-title\">\r\n");
#nullable restore
#line 203 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                         if (messenge.Count != 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <span> You have ");
#nullable restore
#line 205 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                       Write(messenge.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("  new notifications</span>\r\n");
#nullable restore
#line 206 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <a href=\"/UserAdmin/Messange/List\">view all</a>\r\n                                    </span>\r\n                                    <div class=\"nofity-list\">\r\n\r\n");
#nullable restore
#line 212 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                         foreach (var item in messenge)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a");
                BeginWriteAttribute("href", " href=\"", 12597, "\"", 12637, 2);
                WriteAttributeValue("", 12604, "/UserAdmin/Messange/Show/", 12604, 25, true);
#nullable restore
#line 214 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
WriteAttributeValue("", 12629, item.Id, 12629, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"notify-item\">\r\n                                                <div class=\"notify-thumb\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c020779", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                </div>\r\n                                                <div class=\"notify-text\">\r\n                                                    <p>");
#nullable restore
#line 219 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                  Write(item.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                    <span class=\"msg\">");
#nullable restore
#line 220 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                                 Write(item.Description.Substring(0, 19));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ...</span>\r\n                                                    <span>");
#nullable restore
#line 221 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                     Write(item.Date.ToShortTimeString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </div>\r\n                                            </a>\r\n");
#nullable restore
#line 224 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
                WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <!-- header area end -->
            <!-- page title area start -->
            <div class=""page-title-area"">
                <div class=""row align-items-center"">
                    <div class=""col-sm-6"">
                        <div class=""breadcrumbs-area clearfix"">
                            <h4 class=""page-title pull-left"">");
#nullable restore
#line 241 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                        Write(ViewData["Location"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                            <ul class=""breadcrumbs pull-left"">
                                <li><a href=""https://fontawesome.com/v5/search?m=free"">Icons = >  Font Awsome ( only Free)</a></li>
                                <li> <a href=""https://icons.getbootstrap.com/""> Bootstrap</a></li>
                            </ul>


                        </div>
                    </div>
                    <div class=""col-sm-6 clearfix"">
                        <div class=""user-profile pull-right"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c49f8d85c5be9dc11b29009bbd18eac8fe725c025293", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 14746, "~/img/Profile/", 14746, 14, true);
#nullable restore
#line 252 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
AddHtmlAttributeValue("", 14760, user.Image, 14760, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <h4 class=\"user-name dropdown-toggle\" data-toggle=\"dropdown\">");
#nullable restore
#line 253 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
                                                                                    Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fa fa-angle-down\"></i></h4>\r\n                            <div class=\"dropdown-menu\">\r\n                                <a class=\"dropdown-item\" href=\"/UserAdmin/Messange/List\">Message</a>\r\n                                <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 15146, "\"", 15179, 2);
                WriteAttributeValue("", 15153, "/Home/Index/", 15153, 12, true);
#nullable restore
#line 256 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
WriteAttributeValue("", 15165, user.UserName, 15165, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Show My Profile</a>
                                <a class=""dropdown-item"" href=""/UserAdmin/Settings/Index"">Settings</a>
                                <a class=""dropdown-item"" href=""/Signin/LogOut"" "">Log Out</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>



            ");
#nullable restore
#line 267 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        </div>
        <!-- main content area end -->
        <!-- footer area start-->
        <footer>
            <div class=""footer-area"">
                <p>© Copyright 2018. All right reserved. Template by <a href=""https://colorlib.com/wp/"">Colorlib</a>.</p>
            </div>
        </footer>
        <!-- footer area end-->
    </div>
    <!-- page container area end -->
    <!-- offset area start -->
");
                WriteLiteral("    <!-- offset area end -->\r\n\r\n    ");
#nullable restore
#line 467 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Shared\_UserAdminLayout.cshtml"
Write(RenderSection("footer_link", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PorfolioDbContext dbContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
