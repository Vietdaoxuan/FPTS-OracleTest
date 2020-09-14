using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces.InvoicesSummaryReport;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    public class InvoiceSummaryReportAPIController
    {
        private readonly IInvoicesSummaryReportContext _invoiceSummaryReportContext;

        public InvoiceSummaryReportAPIController(IInvoicesSummaryReportContext invoiceSummaryReportContext)
        {
            this._invoiceSummaryReportContext = invoiceSummaryReportContext;
        }
     
       
    }
}
