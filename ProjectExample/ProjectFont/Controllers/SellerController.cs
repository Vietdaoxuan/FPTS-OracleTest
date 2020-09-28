using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces.Sellers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectFont.AppCodes.CallAPI;

namespace ProjectFont.Controllers
{
    public class SellerController : Controller
    {

        private readonly ISellerContext _sellerContext;

        public SellerController(ISellerContext sellerContext)
        {
            this._sellerContext = sellerContext;
        }
        public async Task<IActionResult> Index(int sellerID, string sellerName)
        {
            var dataSet = this._sellerContext.Get(sellerID, sellerName);
            DataTable dataTable;
            var mapper = new DataNamesMapper<Seller>();
            if (dataSet.Tables.Count > 0)
            {
                dataTable = dataSet.Tables[0];
                List<Seller> listSeller = new List<Seller>();
                for (int i = 0; i < dataSet.Tables.Count; i++)
                {
                    Seller sellers = new Seller();
                    sellers.SellerID = Convert.ToInt32(dataTable.Rows[i]["SELLERID"]);
                    sellers.SellerName = dataTable.Rows[i]["SELLERNAME"].ToString();
                    sellers.AccountName = dataTable.Rows[i]["ACCOUNTNAME"].ToString();
                    sellers.AccountNumber = dataTable.Rows[i]["ACCOUNTNUMBER"].ToString();
                    sellers.Address = dataTable.Rows[i]["ADDRESS"].ToString();
                    listSeller.Add(sellers);
                }
                return View(dataTable);
            }
            return View();
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
