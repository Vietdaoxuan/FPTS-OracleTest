using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Config
{
    /// <summary>
    /// Định nghĩa tất cả các sp.
    /// </summary>
    public class SPRoutes
    {
        public const string SP_HUONGVU_SEARCH_EMPLOYEES = "huongvu_search_Employees";

        //SP for Invoices
        public const string SP_KIENPC_ADD_INVOICE = "KIENPC_INSERT_INVOICE";

        public const string SP_KIENPC_UPDATE_INVOICE = "KIENPC_UPDATE_INVOICE";

        public const string SP_KIENPC_DELETE_INVOICE = "KIENPC_DELETE_INVOICE";

        public const string SP_KIENPC_SEARCH_INVOICES = "kienpc_search_Invoices";

        public const string SP_TUNGTT_SUMMARY_REPORT_INVOICES = "tungtt_invoice_summary_report";


        //Seller
        public const string SP_SELLER_SEARCH = "SP_SELLER_SEARCH";
    }
}
