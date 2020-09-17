using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces.InvoicesSummaryReport
{
    public interface IInvoicesSummaryReportContext : IDataContext<Invoice>
    {
        DataSet Get(Invoice searchOptions);
    }
}
