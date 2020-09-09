using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces.Invoices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class InvoiceAPIController : ControllerBase
    {
        private readonly IInvoiceContext _invoiceContext;

        public InvoiceAPIController(IInvoiceContext invoiceContext)
        {
            this._invoiceContext = invoiceContext;
        }
   
        [HttpGet(ApiRoute.Invoices)]
        public JToken GetInvoicesJToken(int invoiceID, string company)
        {
            Invoice searchOptions = new Invoice { ID = 1 , Company = company};

            var dataSet = this._invoiceContext.Get(searchOptions);

            DataTable dataTable;

            var mapper = new DataNamesMapper<Invoice>();

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

        [HttpGet(ApiRoute.InvoicesDataSet)]
        public DataSet GetInvoicesDataSet(Invoice searchOptions)
        {
            return this._invoiceContext.Get(searchOptions);            
        }

        [HttpPost(ApiRoute.InsertInvoices)]
        public ResponseMessage Post([FromBody] Invoice invoice)
        {
            if (invoice != null)
            {
                return this._invoiceContext.Add(invoice);
            }
            else
            {
                return new ResponseMessage { Code = "-1", Message = "INVALID_DATA" };
            }
        }

        [HttpPut(ApiRoute.UpdateEmployees)]
        public ResponseMessage Put([FromBody] Invoice invoice)
        {
            if (invoice != null)
            {
                return this._invoiceContext.Add(invoice);
            }
            else
            {
                return new ResponseMessage { Code = "-1", Message = "INVALID_DATA" };
            }
        }


        [HttpDelete(ApiRoute.DeleteEmployees)]
        public ResponseMessage Delete(int invoiceID)
        {
            if (invoiceID > 0)
            {
                return this._invoiceContext.Delete(invoiceID);
            }
            else
            {
                return new ResponseMessage { Code = "-1", Message = "INVALID_DATA" };
            }
        }
    }
}