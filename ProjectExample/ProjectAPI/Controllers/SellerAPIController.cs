using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces.Sellers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerAPIController : ControllerBase
    {
        private readonly ISellerContext _sellerContext;

        public SellerAPIController(ISellerContext sellerContext)
        {
            this._sellerContext = sellerContext;
        }

        [HttpGet(ApiRoute.Sellers)]
        public JToken GetSellers(Seller searchOptions)
        {
            var dataSet = this._sellerContext.Get(searchOptions);

            DataTable dataTable;

            var mapper = new DataNamesMapper<Seller>();

            if (dataSet.Tables.Count > 0)
            {
                dataTable = dataSet.Tables[0];
                return JToken.FromObject(mapper.Map(dataTable));
            }
            else
            {
                return JToken.FromObject("Không bản ghi nào!");
            }
        }
    }
}
