using CoreLib.Config;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using DataServiceLib.Interfaces.Invoices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Implementations.Invoices
{
    public class InvoiceContext : IInvoiceContext
    {
        private readonly ICBaseDataProvider _dataProvider;

        public InvoiceContext(ICBaseDataProvider dataProvider)
        {
            this._dataProvider = dataProvider;
        }

        public ResponseMessage Add(Invoice item)
        {
            if (item == null)
            {
                return new ResponseMessage("-1", "INVALID_DATA");
            }

            return this._dataProvider.GetResponseFromExecutedSP(SPRoutes.SP_KIENPC_ADD_INVOICE, this.InitDbParams(item));
        }

        public ResponseMessage Delete(int invoiceID)
        {
            var paramArr = new[]
            {
                new OracleParameter()
                {
                    ParameterName = "prm_Invoice_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = invoiceID,
                },
            };

            return this._dataProvider.GetResponseFromExecutedSP(SPRoutes.SP_KIENPC_DELETE_INVOICE, paramArr);
        }

        public DataSet Get(Invoice searchOptions)
        {
            var paramArr = new[]
            {
                new OracleParameter()
                {
                    ParameterName = "RefCursor",
                    Direction = ParameterDirection.Output,
                    OracleDbType = OracleDbType.RefCursor,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_INVOICE_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = searchOptions.ID,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_COMPANY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = searchOptions.Company,
                },
            };

            return this._dataProvider.GetDatasetFromSP(SPRoutes.SP_KIENPC_SEARCH_INVOICES, paramArr);
        }

        public DataSet Get(int invoiceID)
        {
            throw new NotImplementedException();
        }

        public DataSet Get()
        {
            throw new NotImplementedException();
        }

        public ResponseMessage Update(Invoice item)
        {
            if (item == null)
            {
                return new ResponseMessage("-1", "INVALID_DATA");
            }

            return this._dataProvider.GetResponseFromExecutedSP(SPRoutes.SP_KIENPC_UPDATE_INVOICE, this.InitDbParams(item));
        }

        private OracleParameter[] InitDbParams(Invoice item)
        {
            return new[]
            {
                new OracleParameter()
                {
                    ParameterName = "prm_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = item.ID,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_INVOICE_CODE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.InvoiceCode,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_CUSTOMER_NAME",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.CustomerName,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_COMPANY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.Company,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_ADDRESS",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.Address,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_EMAIL",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.Email,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_TAX_CODE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.TaxCode,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_PAYMENT_METHOD",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.PaymentMethod,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_CURRENCY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.Currence,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_EXCHANGE_RATE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Double,
                    Value = item.ExchangeRate,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_TOTAL_MONEY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Double,
                    Value = item.TotalMoney,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_STATUS",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.Status,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_SELLER_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = item.SellerID,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_TRANS_DATE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Date,
                    Value = item.TransDate,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_REPLACE_DATE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Date,
                    Value = item.ReplaceDate,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_REPLACE_INVOICE_CODE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.ReplaceInvoiceCode,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_SEND_CUSTOMER",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = item.SendCustomer,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_IS_CONVERT",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = item.IsConvert,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_PDF_FILE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.PdfFile,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_SEARCH_CODE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.SearchCode,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_INVOICE_SETUP_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = item.InvoiceSetupID,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_ACCOUNT_INVOICE_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.AccountInvoiceID,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_SOURCE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.Source,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_XML_FILE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = item.XmlFile,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_AMOUNT_TAX",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Double,
                    Value = item.AmountTax,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_AMOUNT_TOTAL",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Double,
                    Value = item.AmountTotal,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_REPLACE_INVOICE_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = item.ReplaceInvoiceID,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_APPROVE_DATE",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Date,
                    Value = item.ApproveDate,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_CREATED_BY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.CreatedBy,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_CREATED_ON",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Date,
                    Value = item.CreatedOn,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_MODIFIED_BY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.ModifiedBy,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_MODIFIED_ON",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Date,
                    Value = item.ModifiedOn,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_DELETED_BY",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = item.DeletedBy,
                },
                new OracleParameter()
                {
                    ParameterName = "prm_DELETED_ON",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Date,
                    Value = item.DeletedOn,
                },
            };
        }
    }
}
