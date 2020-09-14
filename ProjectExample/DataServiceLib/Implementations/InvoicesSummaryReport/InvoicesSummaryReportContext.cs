using CoreLib.Config;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using DataServiceLib.Interfaces.InvoicesSummaryReport;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Implementations.InvoicesSummaryReport
{
    public class InvoicesSummaryReportContext : IInvoicesSummaryReportContext
    {
        private readonly ICBaseDataProvider _dataProvider;

        public InvoicesSummaryReportContext(ICBaseDataProvider dataProvider)
        {
            this._dataProvider = dataProvider;
        }


        public ResponseMessage Add(Invoice item)
        {
            throw new NotImplementedException();
        }

        public DataSet Get(Invoice searchOptions)
        {
            var paramArr = new[]
             {
                new OracleParameter()
                {
                    ParameterName = "P_Cur",
                    Direction = ParameterDirection.Output,
                    OracleDbType = OracleDbType.RefCursor,
                },
                //new OracleParameter()
                //{
                //    ParameterName = "P_FromDate",
                //    Direction = ParameterDirection.Input,
                //    OracleDbType = OracleDbType.TimeStamp,

                //},
                //new OracleParameter()
                //{
                //    ParameterName = "P_ToDate",
                //    Direction = ParameterDirection.Input,
                //    OracleDbType = OracleDbType.TimeStamp,
                //},
                new OracleParameter()
                {
                    ParameterName = "P_SellerID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int32,
                    Value = searchOptions.SellerID,
                },
            };

            return this._dataProvider.GetDatasetFromSP(SPRoutes.SP_TUNGTT_SUMMARY_REPORT_INVOICES, paramArr);
        }

        public DataSet Get()
        {
            throw new NotImplementedException();
        }

        public ResponseMessage Update(Invoice item)
        {
            throw new NotImplementedException();
        }
    }
}
