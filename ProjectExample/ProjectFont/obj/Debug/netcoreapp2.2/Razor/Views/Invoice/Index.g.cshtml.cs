#pragma checksum "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf2a241366d19843a8dac71b32ce033a4873209"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf2a241366d19843a8dac71b32ce033a4873209", @"/Views/Invoice/Index.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreLib.Entities.Invoice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(295, 38, false);
#line 17 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(389, 47, false);
#line 20 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(436, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 48, false);
#line 23 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 43, false);
#line 26 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 43, false);
#line 29 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(738, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(794, 41, false);
#line 32 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(835, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(891, 43, false);
#line 35 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(934, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(990, 49, false);
#line 38 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1095, 44, false);
#line 41 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Currence));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1195, 48, false);
#line 44 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExchangeRate));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1299, 46, false);
#line 47 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalMoney));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1401, 42, false);
#line 50 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1499, 44, false);
#line 53 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SellerID));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1599, 45, false);
#line 56 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransDate));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1700, 47, false);
#line 59 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReplaceDate));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1803, 54, false);
#line 62 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReplaceInvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1913, 48, false);
#line 65 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SendCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2017, 45, false);
#line 68 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsConvert));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2118, 43, false);
#line 71 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PdfFile));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2217, 46, false);
#line 74 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SearchCode));

#line default
#line hidden
            EndContext();
            BeginContext(2263, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2319, 50, false);
#line 77 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceSetupID));

#line default
#line hidden
            EndContext();
            BeginContext(2369, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2425, 52, false);
#line 80 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountInvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2533, 42, false);
#line 83 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(2575, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2631, 43, false);
#line 86 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.XmlFile));

#line default
#line hidden
            EndContext();
            BeginContext(2674, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2730, 45, false);
#line 89 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AmountTax));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2831, 47, false);
#line 92 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AmountTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2878, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2934, 52, false);
#line 95 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReplaceInvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3042, 47, false);
#line 98 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApproveDate));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3145, 45, false);
#line 101 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3190, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3246, 45, false);
#line 104 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(3291, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3347, 46, false);
#line 107 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3449, 46, false);
#line 110 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
            EndContext();
            BeginContext(3495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3551, 45, false);
#line 113 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3652, 45, false);
#line 116 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedOn));

#line default
#line hidden
            EndContext();
            BeginContext(3697, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 122 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(3815, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3864, 37, false);
#line 125 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(3901, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3957, 46, false);
#line 128 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(4003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4059, 47, false);
#line 131 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(4106, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4162, 42, false);
#line 134 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Company));

#line default
#line hidden
            EndContext();
            BeginContext(4204, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4260, 42, false);
#line 137 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4302, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4358, 40, false);
#line 140 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4398, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4454, 42, false);
#line 143 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(4496, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4552, 48, false);
#line 146 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(4600, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4656, 43, false);
#line 149 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Currence));

#line default
#line hidden
            EndContext();
            BeginContext(4699, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4755, 47, false);
#line 152 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExchangeRate));

#line default
#line hidden
            EndContext();
            BeginContext(4802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4858, 45, false);
#line 155 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalMoney));

#line default
#line hidden
            EndContext();
            BeginContext(4903, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4959, 41, false);
#line 158 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(5000, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5056, 43, false);
#line 161 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SellerID));

#line default
#line hidden
            EndContext();
            BeginContext(5099, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5155, 44, false);
#line 164 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransDate));

#line default
#line hidden
            EndContext();
            BeginContext(5199, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5255, 46, false);
#line 167 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReplaceDate));

#line default
#line hidden
            EndContext();
            BeginContext(5301, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5357, 53, false);
#line 170 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReplaceInvoiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(5410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5466, 47, false);
#line 173 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SendCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(5513, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5569, 44, false);
#line 176 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsConvert));

#line default
#line hidden
            EndContext();
            BeginContext(5613, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5669, 42, false);
#line 179 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PdfFile));

#line default
#line hidden
            EndContext();
            BeginContext(5711, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5767, 45, false);
#line 182 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SearchCode));

#line default
#line hidden
            EndContext();
            BeginContext(5812, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5868, 49, false);
#line 185 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceSetupID));

#line default
#line hidden
            EndContext();
            BeginContext(5917, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5973, 51, false);
#line 188 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountInvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(6024, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6080, 41, false);
#line 191 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Source));

#line default
#line hidden
            EndContext();
            BeginContext(6121, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6177, 42, false);
#line 194 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.XmlFile));

#line default
#line hidden
            EndContext();
            BeginContext(6219, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6275, 44, false);
#line 197 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AmountTax));

#line default
#line hidden
            EndContext();
            BeginContext(6319, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6375, 46, false);
#line 200 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AmountTotal));

#line default
#line hidden
            EndContext();
            BeginContext(6421, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6477, 51, false);
#line 203 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReplaceInvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(6528, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6584, 46, false);
#line 206 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApproveDate));

#line default
#line hidden
            EndContext();
            BeginContext(6630, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6686, 44, false);
#line 209 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(6730, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6786, 44, false);
#line 212 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(6830, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6886, 45, false);
#line 215 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(6931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6987, 45, false);
#line 218 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedOn));

#line default
#line hidden
            EndContext();
            BeginContext(7032, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(7088, 44, false);
#line 221 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedBy));

#line default
#line hidden
            EndContext();
            BeginContext(7132, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(7188, 44, false);
#line 224 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedOn));

#line default
#line hidden
            EndContext();
            BeginContext(7232, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(7288, 65, false);
#line 227 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(7353, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(7374, 71, false);
#line 228 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(7445, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(7466, 69, false);
#line 229 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(7535, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 232 "C:\Users\fitthuctap01.FPTS\Desktop\ProjectExample\ProjectFont\Views\Invoice\Index.cshtml"
}

#line default
#line hidden
            BeginContext(7574, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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