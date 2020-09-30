using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces.InvoicesSummaryReport;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class InvoiceSummaryReportAPIController : ControllerBase
    {
        private readonly IInvoicesSummaryReportContext _invoiceSummaryReportContext;

        
        public InvoiceSummaryReportAPIController(IInvoicesSummaryReportContext invoiceSummaryReportContext)
        {
            this._invoiceSummaryReportContext = invoiceSummaryReportContext;
        }


        //[HttpGet(ApiRoute.InvoiceSummaryReport)]
        //public JToken GetInvoicesummaryReport(int invoiceID)
        //{
        //    InvoiceSummaryReport searchOptions = new InvoiceSummaryReport { ID = 1 };

        //    var dataSet = this._invoiceSummaryReportContext.Get(searchOptions);

        //    DataTable dataTable;

        //    var mapper = new DataNamesMapper<InvoiceSummaryReport>();

        //    if (dataSet.Tables.Count > 0)
        //    {
        //        dataTable = dataSet.Tables[0];
        //        return JToken.FromObject(mapper.Map(dataTable));
        //    }
        //    else
        //    {
        //        return JToken.FromObject("Không bản ghi nào!");
        //    }
        //}
        //news 
        
        [HttpGet(ApiRoute.InvoiceSummaryReport)]
        public DataSet GetList([FromQuery] InvoiceSummaryReport searchOption )
        {
            return this._invoiceSummaryReportContext.Get(searchOption);
        }


    }
}
