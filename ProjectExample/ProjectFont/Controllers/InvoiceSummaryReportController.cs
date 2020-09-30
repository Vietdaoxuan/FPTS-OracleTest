using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonLib.Interfaces;
using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProjectFont.AppCodes;
using ProjectFont.AppCodes.CallAPI;
using ProjectFont.Models;
using ProjectFont.Models.ViewModels;
using ProjectFont.Services.Implementations;

namespace ProjectFont.Controllers
{
    public class InvoiceSummaryReportController : Controller
    {   
        private readonly ICommon _common;     
        private readonly IHttpService _httpService;
        private readonly IConfiguration _configuration;

        public InvoiceSummaryReportController(IHttpService httpService, ICommon common, IConfiguration configuration)
        {

            this._common = common;
            this._httpService = httpService;
            this._configuration = configuration;
        }

        //public async Task<IActionResult> InvoiceSummaryReport()
        //{
        //    List<InvoiceSummaryReport> list = new List<InvoiceSummaryReport>();
        //    InvoiceSummaryReport invoicesummaryreport2 = new InvoiceSummaryReport { ID = 2, FormNo = "KT/AA/20P", Symbol = "K20TAA" };
        //    list.Add(invoicesummaryreport2);
        //    return View(list);

        //}
        //public async Task<JsonResult> Get()
        //{
        //    string prm = "?invoiceID=1";
        //    var result = await CallAPIService.SearchTemplateAsync(ApiRoute.InvoiceSummaryReport + prm);
        //    var jsonCode = JsonConvert.SerializeObject(result);
        //    return Json(jsonCode);
        //}

        public async Task<IActionResult> InvoiceSummaryReport()
        {
            //var viewModel = new InvoiceSummaryReportViewModels();
            //var dataTableInvoiceList = await this._httpService.FetchDataTableFromGetUrl(
            //        this._configuration["ApiUrl"] + ApiRoute.InvoiceSummaryReport + "?" + this._common.ToQueryString(new InvoiceSummaryReport()
            //        {
            //            ID = 1
            //        }));

            //this.ViewBag.CommonType = dataTableInvoiceList.ToListItem<InvoiceSummaryReport>().ToList();
            //return this.View(viewModel);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> InvoiceSummaryReportList(InvoiceSummaryReport invoiceSummaryReport, PaginationDataTableModel pagination)
        {
            IEnumerable<InvoiceSummaryReport> all = null;
            if(all == null)
            {
                // lấy thong tin từ api
                var dataTable = await this._httpService.FetchDataTableFromGetUrl(
                    this._configuration["ApiUrl"] + ApiRoute.InvoiceSummaryReport + "?" + this._common.ToQueryString(new InvoiceSummaryReport()
                    {

                        Id = invoiceSummaryReport.Id,                 
                    }));

                 all = dataTable.ToListItem<InvoiceSummaryReport>();

                //this.HttpContext.Session.SetObject("InvoiceSummaryReportList", all);
            }

            var paginatedData = all.Skip(pagination.start).Take(pagination.length);

            return this.Json(new
            {
                pagination.draw,
                recordsTotal = all.Count(),
                recordsFiltered = all.Count(),
                data = paginatedData,
            });                   
        }

    }
}