#pragma checksum "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43dd6fc75c2894320e0caa1c61f5d5ed3d81e957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CTCTDTSV), @"mvc.1.0.view", @"/Views/Home/CTCTDTSV.cshtml")]
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
#line 2 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\_ViewImports.cshtml"
using MVC_DangKyMonHoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43dd6fc75c2894320e0caa1c61f5d5ed3d81e957", @"/Views/Home/CTCTDTSV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1349b74cf9f03f9276ee7ac18b398772a873dafc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CTCTDTSV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_DangKyMonHoc.Models.CT_CTDT_SV>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
  
    ViewData["Title"] = "CTCTDTSV";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><b>CHƯƠNG TRÌNH ĐÀO TẠO</b></h1>\r\n<hr />\r\n");
#nullable restore
#line 10 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 13 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
         Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 14 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Mã Môn Học
                    </th>
                    <th>
                        Tên Môn Học
                    </th>
                    <th>
                        Số tín chỉ
                    </th>
                    <th>
                        Hệ số HP
                    </th>
                    <th>
                        Thực hành
                    </th>
                    <th>
                        Học Kỳ
                    </th>
                   
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 42 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MaMh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TenMh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Sotinchi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HesoHp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Thuchanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MaHk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 64 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 67 "G:\Luan_Van\MVC_DangKyMonHoc\MVC_DangKyMonHoc\Views\Home\CTCTDTSV.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_DangKyMonHoc.Models.CT_CTDT_SV>> Html { get; private set; }
    }
}
#pragma warning restore 1591