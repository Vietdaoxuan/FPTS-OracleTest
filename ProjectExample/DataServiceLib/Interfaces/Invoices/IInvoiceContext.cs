﻿using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces.Invoices
{
    public interface IInvoiceContext : IDataContext<Invoice>
    {
        DataSet Get(Invoice searchOptions);

        DataSet Get(int invoiceID);

        ResponseMessage Delete(int invoiceID);
    }
}
