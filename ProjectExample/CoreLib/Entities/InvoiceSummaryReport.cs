using CoreLib.DataTableToObject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class InvoiceSummaryReport
    {

        //public InvoiceSummaryReport()
        //{
        //    this.PageSize = 100000;
        //    this.PageNumber = 1;
        //}

        //public int PageSize { get; set; }

        //public int PageNumber { get; set; }

        [DataNames("ID")]
        public int Id { get; set; }

        [DataNames("FORMNO")]
        public string FormNo { get; set; }

        [DataNames("SYMBOL")]
        public string Symbol { get; set; }

        [DataNames("INVOICE_CODE")]
        public string Invoice_Code { get; set; }

        [DataNames("TRANS_DATE")]
        public DateTime Trans_Date { get; set; }

        [DataNames("COMPANY")]
        public string Company { get; set; }
  
        [DataNames("TAX_CODE")]
        public string Tax_Code { get; set; }

        [DataNames("PRODUCTNAME")]
        public string ProductName { get; set; }

        [DataNames("POINT")]
        public string Point { get; set; }

        [DataNames("QUANTITY")]
        public int Quantity { get; set; }

        [DataNames("TOTAL_MONEY")]
        public double Total_Money { get; set; }

        [DataNames("Tax")]
        public int Tax { get; set; }

        [DataNames("AMOUNT_TAX")]
        public double Amount_Tax { get; set; }

        [DataNames("AMOUNT_TOTAL")]
        public double Amount_Total { get; set; }

        [DataNames("TYPE_NAME")]
        public string Type_Name { get; set; }

    

       

     

        

    }
}
