using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLib.Config;
using CoreLib.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectFont.AppCodes.CallAPI;

namespace ProjectFont.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> Get(Seller searchOptions)
        {
            string prm = "";
            var result = await CallAPIService.SearchTemplateAsync(ApiRoute.Invoices + prm);
            var jsonCode = JsonConvert.SerializeObject(result);
            return Json(jsonCode);
        }
    }
}
