#pragma checksum "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ab1c09ca37fd77d7898afa171154136bb2baade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assistant_Search), @"mvc.1.0.view", @"/Views/Assistant/Search.cshtml")]
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
#line 1 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\_ViewImports.cshtml"
using ParfolioWebSiteView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\_ViewImports.cshtml"
using ParfolioWebSiteView.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\_ViewImports.cshtml"
using ParfolioWebSiteView.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab1c09ca37fd77d7898afa171154136bb2baade", @"/Views/Assistant/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9143321d233c74a0a8179edfc1316b424f8169f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Assistant_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Assistant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero hero-single route bg-image"" style=""background-image: url(/img/overlay-bg.jpg)"">
    <div class=""overlay-mf""></div>
    <div class=""hero-content display-table"">
        <div class=""table-cell"">
            <div class=""container"">
                <h2 class=""hero-title mb-4"">Search</h2>
                <ol class=""breadcrumb d-flex justify-content-center"">
");
#nullable restore
#line 14 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                     if (Model.User == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"breadcrumb-item\">\r\n                            <a href=\"#\">All</a>\r\n                        </li>\r\n");
            WriteLiteral("                        <li class=\"breadcrumb-item active\">\r\n                            <a href=\"#\"> ");
#nullable restore
#line 21 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                    Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 23 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"breadcrumb-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 953, "\"", 992, 2);
            WriteAttributeValue("", 960, "/Home/Index/", 960, 12, true);
#nullable restore
#line 27 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 972, Model.User.UserName, 972, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                  Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li class=\"breadcrumb-item\">\r\n                            <a href=\"#\"> ");
#nullable restore
#line 30 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                    Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 32 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </ol>
            </div>
        </div>
    </div>
</div>

<main id=""main"">

    <!-- ======= Blog Single Section ======= -->
    <section class=""blog-wrapper sect-pt4"" id=""search"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""post-box"">

                        <div class=""widget-sidebar mb-2 p-0 sidebar-search"">
                            <h5 class=""sidebar-title"">Search All Blogs and Users</h5>
                            <div class=""sidebar-content"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab1c09ca37fd77d7898afa171154136bb2baade8663", async() => {
                WriteLiteral(@"
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control"" required name=""info"" placeholder=""Search for...""
                                               aria-label=""Search for..."">
                                        <input type=""checkbox"" style=""width:0;height:0;visibility:hidden;"" name=""isAll"" checked");
                BeginWriteAttribute("value", " value=\"", 2300, "\"", 2324, 1);
#nullable restore
#line 57 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 2308, true.ToString(), 2308, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <span class=""input-group-btn"">
                                            <button class=""btn btn-secondary btn-search"" type=""submit"">
                                                <span class=""bi bi-search""></span>
                                            </button>
                                        </span>

                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 69 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                         if (Model.Tags != null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"post-meta\">\r\n                                <h1 class=\"article-title\">All Tags</h1>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                 foreach (var item in Model.Tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn ml-1 rounded-pill btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3241, "\"", 3276, 2);
            WriteAttributeValue("", 3248, "/Assistant/TagBlogs/", 3248, 20, true);
#nullable restore
#line 77 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 3268, item.Id, 3268, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"bi bi-tag\"></i></a>\r\n");
#nullable restore
#line 78 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 81 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                         if (Model.Users != null && Model.Blogs != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                             if (!(Model.Users.Count == 0 && Model.Blogs.Count == 0))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"post-meta\">\r\n                                    <h1 class=\"article-title\">Search Resault</h1>\r\n");
#nullable restore
#line 89 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                     foreach (var item in Model.Blogs)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul>\r\n                                            <li>\r\n                                                <span class=\"bi bi-chat-left-text\"></span>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4130, "\"", 4162, 2);
            WriteAttributeValue("", 4137, "/Home/SinglePage/", 4137, 17, true);
#nullable restore
#line 94 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 4154, item.Id, 4154, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                            <li>\r\n                                                <span class=\"bi bi-person\"></span>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4416, "\"", 4454, 2);
            WriteAttributeValue("", 4423, "/Home/Index/", 4423, 12, true);
#nullable restore
#line 98 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 4435, item.User.UserName, 4435, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                                     Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                            <li>\r\n                                                <span class=\"bi bi-collection\"></span>\r\n                                                <a href=\"#\">");
#nullable restore
#line 102 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                       Write(item.BlogCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                            <li>\r\n                                                <span class=\"bi bi-calendar3\"></span>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4997, "\"", 5029, 2);
            WriteAttributeValue("", 5004, "/Home/SinglePage/", 5004, 17, true);
#nullable restore
#line 106 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 5021, item.Id, 5021, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 106 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                               Write(item.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 106 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                                              Write(item.Date.ToString("Y"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                        </ul>\r\n");
#nullable restore
#line 109 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 111 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                     foreach (var item in Model.Users)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul>\r\n                                            <li>\r\n                                                <span class=\"bi bi-person\"></span>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5556, "\"", 5589, 2);
            WriteAttributeValue("", 5563, "/Home/Index/", 5563, 12, true);
#nullable restore
#line 116 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 5575, item.UserName, 5575, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 116 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                                Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                            <li>\r\n                                                <span class=\"bi bi-chat-left-text\"></span>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5854, "\"", 5887, 2);
            WriteAttributeValue("", 5861, "/Home/Index/", 5861, 12, true);
#nullable restore
#line 120 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 5873, item.UserName, 5873, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 120 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                                Write(item.Blogs.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                        </ul>\r\n");
#nullable restore
#line 123 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 125 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-md-4\">\r\n");
#nullable restore
#line 132 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                     if (Model.User != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"widget-sidebar sidebar-search\">\r\n                            <h5 class=\"sidebar-title\">Search in ");
#nullable restore
#line 135 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                           Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <div class=\"sidebar-content\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab1c09ca37fd77d7898afa171154136bb2baade24247", async() => {
                WriteLiteral(@"
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control"" name=""info"" placeholder=""Search for...""
                                               aria-label=""Search for..."">
                                        <input type=""checkbox""
                                               style=""width:0;height:0;visibility:hidden;""
                                               name=""isAll""");
                BeginWriteAttribute("value", "\r\n                                               value=\"", 7107, "\"", 7180, 1);
#nullable restore
#line 144 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 7163, false.ToString(), 7163, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" name=\"userName\"");
                BeginWriteAttribute("value", " value=\"", 7262, "\"", 7290, 1);
#nullable restore
#line 145 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 7270, Model.User.UserName, 7270, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <span class=""input-group-btn"">
                                            <button class=""btn btn-secondary btn-search"" type=""submit"">
                                                <span class=""bi bi-search""></span>
                                            </button>
                                        </span>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 155 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"widget-sidebar\">\r\n                        <h5 class=\"sidebar-title\">Top Post in All Users</h5>\r\n                        <div class=\"sidebar-content\">\r\n                            <ul class=\"list-sidebar\">\r\n");
#nullable restore
#line 161 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                 foreach (var item in Model.Popliar)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 8266, "\"", 8298, 2);
            WriteAttributeValue("", 8273, "/Home/SinglePage/", 8273, 17, true);
#nullable restore
#line 164 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
WriteAttributeValue("", 8290, item.Id, 8290, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 164 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 166 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Views\Assistant\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section><!-- End Blog Single Section -->\r\n\r\n</main><!-- End #main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
