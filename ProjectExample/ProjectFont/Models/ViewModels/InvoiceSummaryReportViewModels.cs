using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Models.ViewModels
{
    public class InvoiceSummaryReportViewModels
    {
        public IEnumerable<InvoiceSummaryReport> invoiceSummaryReports { get; set; }

        public InvoiceSummaryReport invoiceSummaryReport { get; set; }
    }
}
