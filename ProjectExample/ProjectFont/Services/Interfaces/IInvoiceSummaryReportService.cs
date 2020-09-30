using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Services.Interfaces
{
    public interface IInvoiceSummaryReportService
    {
        Task<IEnumerable<InvoiceSummaryReport>> Get(InvoiceSummaryReport searchOptions);
        Task<InvoiceSummaryReport> Get(int invoiceID);
    }
}
