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
        public async Task<IActionResult> Index(int sellerID, string sellerName)
        {
            string prm = "?sellerID=" + sellerID + "&sellerName=" + sellerName;
            var result = await CallAPIService.SearchTemplateAsync(ApiRoute.Sellers + prm);
            var jsonCode = JsonConvert.SerializeObject(result);
            return View(jsonCode);
        }

        public async Task<JsonResult> Get(int sellerID, string sellerName)
        {
            string prm = "?sellerID=" + sellerID + "&sellerName=" + sellerName;
            var result = await CallAPIService.SearchTemplateAsync(ApiRoute.Sellers + prm);
            var jsonCode = JsonConvert.SerializeObject(result);
            return Json(jsonCode);
        }
    }
}
