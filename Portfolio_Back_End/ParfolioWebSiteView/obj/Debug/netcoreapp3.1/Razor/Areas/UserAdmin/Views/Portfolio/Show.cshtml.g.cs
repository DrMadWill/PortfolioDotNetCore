#pragma checksum "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e37c1023ed8174efa7ca9775c16e2756e50b37f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserAdmin_Views_Portfolio_Show), @"mvc.1.0.view", @"/Areas/UserAdmin/Views/Portfolio/Show.cshtml")]
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
using ParfolioWebSiteView.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using ParfolioWebSiteView.Areas.UserAdmin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\_ViewImports.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37c1023ed8174efa7ca9775c16e2756e50b37f1", @"/Areas/UserAdmin/Views/Portfolio/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdaaf48830e875c2c57add07a462fb705564b53", @"/Areas/UserAdmin/_ViewImports.cshtml")]
    public class Areas_UserAdmin_Views_Portfolio_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminPanelHeaderLink", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminPanelScripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
  
    string namesss = "@sweetalert2";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
  
    ViewData["Location"] = "Portfolio";
    ViewData["Title"] = "Portfolio Show";

#line default
#line hidden
#nullable disable
            DefineSection("header_link", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e37c1023ed8174efa7ca9775c16e2756e50b37f17948", async() => {
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
                WriteLiteral("\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 237, "\"", 297, 3);
                WriteAttributeValue("", 244, "//cdn.jsdelivr.net/npm/", 244, 23, true);
#nullable restore
#line 13 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
WriteAttributeValue("", 267, namesss, 267, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 275, "/theme-dark@4/dark.css", 275, 22, true);
                EndWriteAttribute();
                WriteLiteral(@" rel=""stylesheet"">

    <style>
        .image-box {
            position: relative;
            width: 300px;
            height: auto;
        }

        .box-item {
            position: absolute;
            bottom: 10px;
            left: 50%;
            transform: translate(-50%,0);
        }

        #file-ip-1-preview {
            display: none;
        }

        #editfile-ip-1-preview {
            display: none;
        }
    </style>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n<div class=\"main-content-inner\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 mt-5\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h3>\r\n                        ");
#nullable restore
#line 48 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                    <div class=\"row mt-3 text-center\">\r\n                        <div class=\"col-6\">\r\n                            <h4>Main Image</h4>\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e37c1023ed8174efa7ca9775c16e2756e50b37f111069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1289, "~/img/Porfolio/", 1289, 15, true);
#nullable restore
#line 54 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
AddHtmlAttributeValue("", 1304, Model.Image, 1304, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <h4>Description</h4>\r\n                            <div>\r\n                                ");
#nullable restore
#line 60 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                           Write(Html.Raw(Model.PortfolioDetail.Descriptoion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <table class=""table my-3 table-striped"">

                        <tbody>
                            <tr>
                                <th scope=""row"">Name</th>
                                <td>");
#nullable restore
#line 70 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                               Write(Model.PortfolioCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Client</th>\r\n                                <td>");
#nullable restore
#line 74 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                               Write(Model.PortfolioDetail.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Url</th>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2324, "\"", 2366, 1);
#nullable restore
#line 78 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
WriteAttributeValue("", 2331, Model.PortfolioDetail.LocatoionURL, 2331, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Loaction</a></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Date</th>\r\n                                <td>");
#nullable restore
#line 82 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                               Write(Model.Date.ToString("G"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                    <div id=""images"">
                        <div class=""my-2 d-flex justify-content-between"">
                            <h4>
                                Detail Images
                            </h4>
                            <button class=""btn btn-success"" data-toggle=""modal"" data-target=""#imageModalCenter""><i class=""ti-plus""></i></button>
                        </div>
                        <div class=""d-flex justify-content-center flex-wrap"">
");
#nullable restore
#line 94 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                             foreach (var item in Model.PortfolioDetail.DetailImages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"d-inline-block image-box m-2\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e37c1023ed8174efa7ca9775c16e2756e50b37f116609", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3427, "~/img/PorfolioDetails/", 3427, 22, true);
#nullable restore
#line 97 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
AddHtmlAttributeValue("", 3449, item.Image, 3449, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"box-item\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3573, "\"", 3618, 2);
            WriteAttributeValue("", 3580, "/UserAdmin/Detailimage/Delete/", 3580, 30, true);
#nullable restore
#line 99 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
WriteAttributeValue("", 3610, item.Id, 3610, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn delete-btn btn-sm btn-danger\"><i class=\"fa fa-trash-o\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 102 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""imageModalCenter"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Details Image Add</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal""><span>&times;</span></button>
            </div>
            <div class=""modal-body"">
                <div class=""alert alert-warning"" role=""alert"">
                    <strong>Warning!</strong>  Your Maxumum Image Limit 5.
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e37c1023ed8174efa7ca9775c16e2756e50b37f120151", async() => {
                WriteLiteral("\r\n                    <input id=\"pid\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4681, "\"", 4698, 1);
#nullable restore
#line 124 "C:\Users\nofel\OneDrive\Desktop\PortfolioWebSite\Portfolio_Back_End\ParfolioWebSiteView\Areas\UserAdmin\Views\Portfolio\Show.cshtml"
WriteAttributeValue("", 4689, Model.Id, 4689, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Upload</span>
                    </div>
                    <div class=""custom-file"">
                        <input type=""file"" accept=""image/*"" required onchange=""showPreview(event);"" class=""custom-file-input"" id=""file-ip-1"">
                        <label class=""custom-file-label"" for=""file-ip-1"">Choose Image</label>
                    </div>
                    <div class=""w-100 d-flex mt-3 justify-content-center"">
                        <img id=""file-ip-1-preview"" class=""img-fluid"" src=""0"" alt=""your image"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button form=""addForm"" type=""submit"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("footer_link", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e37c1023ed8174efa7ca9775c16e2756e50b37f123272", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        $(document).ready(() => {
            $(document).on('submit', '#addForm', (e) => {
                e.preventDefault();
                Swal.fire({
                    title: 'Give me a second.',
                    text: '""',
                    imageUrl: 'https://media.giphy.com/media/xTkcEQACH24SMPxIQg/giphy.gif',
                    imageWidth: 400,
                    imageHeight: 350,
                    imageAlt: 'Loading',
                });
                let file = $(""#file-ip-1"")[0].files[0];
                var form_data = new FormData();
                form_data.append('file', file);
                form_data.append('id', $(""#pid"").val())
                $.ajax({
                    url: '/UserAdmin/Detailimage/Add',
                    headers: {
                        'RequestVerificationToken': $('input[name=""__RequestVerificationToken""]').val()
                    },
                    type: 'POST',
                    data: form_data,
    ");
                WriteLiteral(@"                contentType: false,
                    processData: false,
                    success: (response) => {
                        if (response.hasOwnProperty('status') && response.status === 201) {
                            location.href = '/UserAdmin/Portfolio/Show/' + $(""#pid"").val();
                        } else if (response.hasOwnProperty('status') && response.status === 400) {
                            alert(""Your Maximum Image Limit 5"")
                        } else {
                            alert(""Not Saved Image.Plase Again Send."");
                        }
                    }
                })
            });


        });

        $(document).on('click', '.delete-btn', function (e) {
            e.preventDefault();
            let url = $(this).attr(""href"");
            let element = this.parentElement.parentElement;
            var __RequestVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
            Swal.fire({
          ");
                WriteLiteral(@"      title: 'Are You Sure Delete?',
                text: ""Unable to return after deletion!"",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Delete',
                cancelButtonText: 'Cancel'
            }).then((result) => {
                if (result.value) {
                    $.ajax({
                        url: url,
                        type: ""get"",
                        beforeSend: function (request) {
                            request.setRequestHeader('RequestVerificationToken', $(""input[name='__RequestVerificationToken']"").val());
                        },
                        dataType: ""json"",
                        success: function (response) {
                            if (response.status == 201) {
                                Swal.fire(
                                    'Deleted!',
                      ");
                WriteLiteral(@"              '',
                                    'success'
                                )

                                element.outerHTML = '';
                            }
                            else if (response.status == 400) {
                                Swal.fire(
                                    'Don""t Deleted',
                                    '',
                                    'error'
                                )
                            }
                        }
                    });
                }
            })
        });


        function showPreview(event) {
            if (event.target.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById(""file-ip-1-preview"");
                preview.src = src;
                preview.style.display = ""block"";
            }
        }
    </script>

    <script src=""//cdn.jsdelivr.net/npm/sweetaler");
                WriteLiteral("t2@11/dist/sweetalert2.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
