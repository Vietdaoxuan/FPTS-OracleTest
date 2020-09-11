using CoreLib.DataTableToObject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class InvoiceSummaryReport
    {
        [DataNames("ID")]
        public int ID { get; set; }

        [DataNames("INVOICE_CODE")]
        public string InvoiceCode { get; set; }

        [DataNames("COMPANY")]
        public string Company { get; set; }
  
        [DataNames("TAX_CODE")]
        public string TaxCode { get; set; }

        [DataNames("TOTAL_MONEY")]
        public double TotalMoney { get; set; }

        [DataNames("SELLER_ID")]
        public int SellerID { get; set; }

        [DataNames("TRANS_DATE")]
        public DateTime TransDate { get; set; }
        
        [DataNames("PDF_FILE")]
        public string PdfFile { get; set; }
   
        [DataNames("XML_FILE")]
        public string XmlFile { get; set; }

        [DataNames("AMOUNT_TAX")]
        public double AmountTax { get; set; }

        [DataNames("AMOUNT_TOTAL")]
        public double AmountTotal { get; set; }

        [DataNames("FORMNO")]
        public string FormNo { get; set; }

        [DataNames("SYMBOL")]
        public string Symbol { get; set; }

        [DataNames("POINT")]
        public string Point { get; set; }

        [DataNames("QUANTITY")]
        public int Quantity { get; set; }

        [DataNames("PRODUCTNAME")]
        public int ProductName { get; set; }

    }
}
