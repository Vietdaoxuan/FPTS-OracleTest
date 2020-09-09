using CoreLib.DataTableToObject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class Invoice
    {
        [DataNames("ID")]
        public int ID { get; set; }

        [DataNames("INVOICE_CODE")]
        public string InvoiceCode { get; set; }

        [DataNames("CUSTOMER_NAME")]
        public string CustomerName { get; set; }

        [DataNames("COMPANY")]
        public string Company { get; set; }

        [DataNames("ADDRESS")]
        public string Address { get; set; }

        [DataNames("EMAIL")]
        public string Email { get; set; }

        [DataNames("TAX_CODE")]
        public string TaxCode { get; set; }

        [DataNames("PAYMENT_METHOD")]
        public string PaymentMethod { get; set; }

        [DataNames("CURRENCY")]
        public string Currence { get; set; }

        [DataNames("EXCHANGE_RATE")]
        public float ExchangeRate { get; set; }

        [DataNames("TOTAL_MONEY")]
        public double TotalMoney { get; set; }

        [DataNames("STATUS")]
        public string Status { get; set; }

        [DataNames("SELLER_ID")]
        public int SellerID { get; set; }

        [DataNames("TRANS_DATE")]
        public DateTime TransDate { get; set; }

        [DataNames("REPLACE_DATE")]
        public DateTime ReplaceDate { get; set; }

        [DataNames("REPLACE_INVOICE_CODE")]
        public string ReplaceInvoiceCode { get; set; }

        [DataNames("SEND_CUSTOMER")]
        public int SendCustomer { get; set; }

        [DataNames("IS_CONVERT")]
        public bool IsConvert { get; set; }

        [DataNames("PDF_FILE")]
        public string PdfFile { get; set; }

        [DataNames("SEARCH_CODE")]
        public string SearchCode { get; set; }

        [DataNames("INVOICE_SETUP_ID")]
        public int InvoiceSetupID { get; set; }

        [DataNames("ACCOUNT_INVOICE_ID")]
        public int AccountInvoiceID { get; set; }

        [DataNames("SOURCE")]
        public string Source { get; set; }

        [DataNames("XML_FILE")]
        public string XmlFile { get; set; }

        [DataNames("AMOUNT_TAX")]
        public double AmountTax { get; set; }

        [DataNames("AMOUNT_TOTAL")]
        public double AmountTotal { get; set; }

        [DataNames("REPLACE_INVOICE_ID")]
        public int ReplaceInvoiceID { get; set; }

        [DataNames("APPROVE_DATE")]
        public DateTime ApproveDate { get; set; }

        [DataNames("CREATED_BY")]
        public string CreatedBy { get; set; }

        [DataNames("CREATED_ON")]
        public DateTime CreatedOn { get; set; }

        [DataNames("MODIFIED_BY")]
        public string ModifiedBy { get; set; }

        [DataNames("MODIFIED_ON")]
        public DateTime ModifiedOn { get; set; }

        [DataNames("DELETED_BY")]
        public string DeletedBy { get; set; }

        [DataNames("DELETED_ON")]
        public DateTime DeletedOn { get; set; }
    }
}
