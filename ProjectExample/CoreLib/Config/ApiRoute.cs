using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Config
{
    /// <summary>
    /// Define API Controller.
    /// </summary>
    public static class ApiRoute
    {
        public const string Employees = "/api/Search-Employees";
        public const string InsertEmployees = "/api/Insert-Employees";
        public const string UpdateEmployees = "/api/Update-Employees";
        public const string DeleteEmployees = "/api/Delete-Employees";

        // API for Invoice
        public const string Invoices = "/api/Search-Invoices";
        public const string InvoicesDataSet = "/api/Search-Invoices-DataSet";
        public const string InsertInvoices = "/api/Insert-Invoices";
        public const string UpdateInvoices = "/api/Update-Invoices";
        public const string DeleteInvoices = "/api/Delete-Invoices";
    }
}
