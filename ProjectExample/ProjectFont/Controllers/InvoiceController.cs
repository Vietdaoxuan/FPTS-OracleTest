using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonLib.Interfaces;
using CoreLib.Config;
using CoreLib.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProjectFont.AppCodes.CallAPI;
using ProjectFont.Services.Interfaces;

namespace ProjectFont.Controllers
{
    public class InvoiceController : Controller
    {
        //private readonly IInvoiceService _invoiceService;
        //private readonly IHttpService _httpService;
        //private readonly IConfiguration _configuration;
        //this._invoiceService = invoiceService;
        //this._httpService = httpService;
        //this._configuration = configuration;
        //IInvoiceService invoiceService, IHttpService httpService, IConfiguration configuration, ICommon common
        private readonly ICommon _common;

        public InvoiceController(ICommon common)
        {

            this._common = common;
        }

        public async Task<IActionResult> Index()
        {
            
            List<Invoice> list = new List<Invoice>();
            Invoice invoice = new Invoice { ID = 1, Company = "nguoi mua khong lay hoa don", Address = "Ha noi" };
            Invoice invoice2 = new Invoice { ID = 2, Company = "nguoi mua khong lay hoa don", Address = "Ha noi" };

            list.Add(invoice);
            list.Add(invoice2);
            return View(list);
        }

        public async Task<JsonResult> Get()
        {
            string prm = "?invoiceID=1&company=";
            var result = await CallAPIService.SearchTemplateAsync(ApiRoute.Sellers + prm);
            var jsonCode = JsonConvert.SerializeObject(result);
            return Json(jsonCode);
        }
    }
}