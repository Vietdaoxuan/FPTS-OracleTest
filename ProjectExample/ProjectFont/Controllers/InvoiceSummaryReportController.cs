using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonLib.Interfaces;
using CoreLib.Config;
using CoreLib.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectFont.AppCodes.CallAPI;

namespace ProjectFont.Controllers
{
    public class InvoiceSummaryReportController : Controller
    {
        private readonly ICommon _common;

        public InvoiceSummaryReportController(ICommon common)
        {

            this._common = common;
        }

        public async Task<IActionResult> InvoiceSummaryReport()
        {
            List<InvoiceSummaryReport> list = new List<InvoiceSummaryReport>();
            InvoiceSummaryReport invoicesummaryreport = new InvoiceSummaryReport();
            //InvoiceSummaryReport invoicesummaryreport2 = new InvoiceSummaryReport { ID = 2, FormNo = "KT/AA/20P", Symbol = "K20TAA" };

            list.Add(invoicesummaryreport);
            //list.Add(invoicesummaryreport2);
            return View(list);
            
        }
        public async Task<JsonResult> Get()
        {
            string prm = "?sellerID=1";
            var result = await CallAPIService.SearchTemplateAsync(ApiRoute.InvoiceSummaryReport + prm);
            var jsonCode = JsonConvert.SerializeObject(result);
            return Json(jsonCode);
        }

        //public IActionResult ExportReport(int formType)
        //{
        //    if(formType == Constrants.PDF)
        //    {
                
        //    }
        //}
    }
}