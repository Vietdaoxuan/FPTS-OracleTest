#pragma checksum "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d3c01a1ffec0c67f14dc07358a43316a9ddf14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Index.cshtml", typeof(AspNetCore.Views_Invoice_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d3c01a1ffec0c67f14dc07358a43316a9ddf14", @"/Views/Invoice/Index.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreLib.Entities.Invoice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(295, 38, false);
#line 17 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(389, 47, false);
#line 20 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(436, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 48, false);
#line 23 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 43, false);
#line 26 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 43, false);
#line 29 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(738, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(794, 41, false);
#line 32 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(835, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(891, 43, false);
#line 35 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(934, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(990, 49, false);
#line 38 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1095, 44, false);
#line 41 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Currence));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(3726, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 122 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(3823, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3872, 37, false);
#line 125 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(3909, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3965, 46, false);
#line 128 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(4011, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4067, 47, false);
#line 131 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(4114, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4170, 42, false);
#line 134 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Company));

#line default
#line hidden
            EndContext();
            BeginContext(4212, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4268, 42, false);
#line 137 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4310, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4366, 40, false);
#line 140 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4406, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4462, 42, false);
#line 143 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(4504, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4560, 48, false);
#line 146 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(4608, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4664, 43, false);
#line 149 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Currence));

#line default
#line hidden
            EndContext();
            BeginContext(4707, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(7269, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(7304, 65, false);
#line 227 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(7369, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(7390, 71, false);
#line 228 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(7461, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(7482, 69, false);
#line 229 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(7551, 137, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"button\" value=\"Bấm\" id=\"btnBam\"/>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 235 "C:\Users\fitthuctap01.FPTS\Desktop\FPTS-OracleTest\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
}   

#line default
#line hidden
            BeginContext(7694, 619, true);
            WriteLiteral(@"    </tbody>
</table>
<script type=""text/javascript"">
    $('body').on('click', '#btnBam', () => {
        

        console.log('aaaaaaaaa');

        $.ajax({
            type: ""GET"",
            url: 'Invoice/Get',
            dataType: ""json"",
            data: {
                invoiceID: 1,
                company: ''
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
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreLib.Entities.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
