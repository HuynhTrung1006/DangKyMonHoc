#pragma checksum "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f11d038daa1b60d2a4b355943657b6f903f5a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DangKyMonHoc_MonHocDangKyView), @"mvc.1.0.view", @"/Views/DangKyMonHoc/MonHocDangKyView.cshtml")]
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
#line 1 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\_ViewImports.cshtml"
using MVC_DangKyMonHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
using MVC_DangKyMonHoc.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
using MVC_DangKyMonHoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f11d038daa1b60d2a4b355943657b6f903f5a46", @"/Views/DangKyMonHoc/MonHocDangKyView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1349b74cf9f03f9276ee7ac18b398772a873dafc", @"/Views/_ViewImports.cshtml")]
    public class Views_DangKyMonHoc_MonHocDangKyView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_DangKyMonHoc.Models.MonHoc>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DangKyMonHoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DangKyMonHoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
  
    ViewData["Title"] = "MonHocDangKyView";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>MonHocDangKyView</h1>


<div>
    <table class=""table table-bordered"" style=""background-color:dodgerblue"">
        <thead>
            <tr>
                <th scope=""col"">Tên môn học</th>
                <th scope=""col"">Số tín chỉ</th>
                <th scope=""col"">Hệ số HP</th>
                <th scope=""col"">Mã môn học</th>

                <th scope=""col"">Số lượng</th>
                <th scope=""col"" width=""80""> </th>


            </tr>
        </thead>
    </table>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f11d038daa1b60d2a4b355943657b6f903f5a465498", async() => {
                WriteLiteral("\r\n        <table class=\"table table-bordered \" style=\"height:400px; overflow-y:scroll;background-color:floralwhite\">\r\n            <tbody>\r\n");
#nullable restore
#line 37 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TenMh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Sotinchi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HesoHp));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MaMh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Thuchanh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td width=\"80\">\r\n                            <input type=\"checkbox\" checked=\"checked\" value=\"true\"");
                BeginWriteAttribute("name", " name=\"", 2058, "\"", 2075, 1);
#nullable restore
#line 58 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
WriteAttributeValue("", 2065, item.MaMh, 2065, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 62 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\DangKyMonHoc\MonHocDangKyView.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n        <input type=\"submit\" name=\"idSubmit\" value=\"Đăng ký\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_DangKyMonHoc.Models.MonHoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
