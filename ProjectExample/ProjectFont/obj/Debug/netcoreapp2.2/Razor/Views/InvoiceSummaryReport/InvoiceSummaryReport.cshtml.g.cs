#pragma checksum "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d378c610d97b9da41e9931c76fd5884b8418de0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceSummaryReport_InvoiceSummaryReport), @"mvc.1.0.view", @"/Views/InvoiceSummaryReport/InvoiceSummaryReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InvoiceSummaryReport/InvoiceSummaryReport.cshtml", typeof(AspNetCore.Views_InvoiceSummaryReport_InvoiceSummaryReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d378c610d97b9da41e9931c76fd5884b8418de0", @"/Views/InvoiceSummaryReport/InvoiceSummaryReport.cshtml")]
    public class Views_InvoiceSummaryReport_InvoiceSummaryReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreLib.Entities.InvoiceSummaryReport>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
  
    ViewData["Title"] = "InvoiceSummaryReport";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(164, 139, true);
            WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Báo Cáo</a>\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(304, 38, false);
#line 16 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(398, 42, false);
#line 19 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.FormNo));

#line default
#line hidden
            EndContext();
            BeginContext(440, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(496, 42, false);
#line 22 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Symbol));

#line default
#line hidden
            EndContext();
            BeginContext(538, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(594, 47, false);
#line 25 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(641, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(697, 45, false);
#line 28 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.TransDate));

#line default
#line hidden
            EndContext();
            BeginContext(742, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(798, 43, false);
#line 31 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(841, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(897, 43, false);
#line 34 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(940, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(996, 47, false);
#line 37 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1099, 41, false);
#line 40 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Point));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1196, 44, false);
#line 43 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1352, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1413, 37, false);
#line 52 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1518, 41, false);
#line 55 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.FormNo));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1627, 41, false);
#line 58 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Symbol));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1736, 46, false);
#line 61 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.InvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1850, 44, false);
#line 64 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.TransDate));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1962, 42, false);
#line 67 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Company));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2072, 42, false);
#line 70 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2182, 46, false);
#line 73 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(2228, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2296, 40, false);
#line 76 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Point));

#line default
#line hidden
            EndContext();
            BeginContext(2336, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2404, 43, false);
#line 79 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2447, 27, true);
            WriteLiteral("\r\n                </td>\r\n\r\n");
            EndContext();
            BeginContext(2959, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 91 "E:\OracleTest\FPTS-OracleTest\ProjectExample\ProjectFont\Views\InvoiceSummaryReport\InvoiceSummaryReport.cshtml"
        }

#line default
#line hidden
            BeginContext(2989, 683, true);
            WriteLiteral(@"    </tbody>

</table>
<input type=""button"" value=""Xuất báo cáo"" id=""btnXuatBaoCao"" />
<script type=""text/javascript"">
    $('body').on('click', '#btnXuatBaoCao', () => {

        console.log('thanh cong');

        $.ajax({
            type: ""GET"",
            url: 'InvoiceSummaryReportController/Get',
            dataType: ""json"",
            data: {
                sellerID: 1,

            },
            success: function (res) {
                var response = JSON.parse(res);
                console.log(response);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
</script>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreLib.Entities.InvoiceSummaryReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
