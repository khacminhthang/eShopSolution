#pragma checksum "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8865dacfdfe168d7e41f7a29ca76834d707c0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8865dacfdfe168d7e41f7a29ca76834d707c0d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30231d102d0f44c9eb29166031ec61d025e3e7c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<eShopSolution.ViewModels.Catalog.Products.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Danh sách sản phẩm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách sản phẩm</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách sản phẩm</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec8865dacfdfe168d7e41f7a29ca76834d707c0d6290", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6 col-xs-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec8865dacfdfe168d7e41f7a29ca76834d707c0d7835", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-9\">\r\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1161, "\"", 1185, 1);
#nullable restore
#line 31 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1169, ViewBag.Keyword, 1169, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""keyword"" class=""form-control"" />
                            </div>
                            <div class=""cold-md-3"">
                                <button type=""submit"" class=""btn btn-primary"">Tìm</button>
                                <button type=""button"" onclick=""window.location.href='/Product/Index'"" class=""btn btn-dark"">Reset</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 45 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 48 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Mã SP
                            </th>
                            <th>
                                Tên
                            </th>
                            <th>
                                Giá nhập
                            </th>
                            <th>
                                Giá bán
                            </th>
                            <th>
                                Số lượng tồn
                            </th>

                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 76 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 80 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 83 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 86 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.OriginalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 89 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 92 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 96 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.ActionLink("Sửa", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                    ");
#nullable restore
#line 97 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.ActionLink("Xem", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                    ");
#nullable restore
#line 98 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                               Write(Html.ActionLink("Xóa", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 101 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            ");
#nullable restore
#line 105 "C:\Users\KHOIDONG.VN\Desktop\STUDY\eShopSolution\eShopSolution.AdminApp\Views\Product\Index.cshtml"
       Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<eShopSolution.ViewModels.Catalog.Products.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
