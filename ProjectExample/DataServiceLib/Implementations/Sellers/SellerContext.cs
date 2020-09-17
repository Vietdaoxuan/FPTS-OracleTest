using CoreLib.Config;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using DataServiceLib.Interfaces.Sellers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Implementations.Sellers
{
    class SellerContext : ISellerContext
    {
        private readonly ICBaseDataProvider _dataProvider;

        public SellerContext(ICBaseDataProvider dataProvider)
        {
            this._dataProvider = dataProvider;
        }

        public ResponseMessage Add(Seller item)
        {
            throw new NotImplementedException();
        }

        public ResponseMessage Delete(string SellerId)
        {
            throw new NotImplementedException();
        }

        public DataSet Get(Seller searchOptions)
        {
            var paramArr = new[]
            {
                new OracleParameter()
                {
                    ParameterName = "P_SellerID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Int64,
                    Value = searchOptions.SellerID,
                },
                new OracleParameter()
                {
                    ParameterName = "P_SellerName",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.SellerName,
                },
                new OracleParameter()
                {
                    ParameterName = "P_Tax",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.Tax,
                },
                new OracleParameter()
                {
                    ParameterName = "P_Address",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.Address,
                },
                new OracleParameter()
                {
                    ParameterName = "P_Phone",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.Phone,
                },
                new OracleParameter()
                {
                    ParameterName = "P_Email",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.Email,
                },
                new OracleParameter()
                {
                    ParameterName = "P_Fax",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.Fax,
                },
                new OracleParameter()
                {
                    ParameterName = "P_AccountNumber",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.AccountNumber,
                },
                new OracleParameter()
                {
                    ParameterName = "P_AccountName",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.AccountName,
                },
                new OracleParameter()
                {
                    ParameterName = "P_BankName",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.BankName,
                },
                new OracleParameter()
                {
                    ParameterName = "P_UserLogin",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = null,
                },
                new OracleParameter()
                {
                    ParameterName = "P_RoleCode",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = null,
                },
                new OracleParameter()
                {
                    ParameterName = "REFCURSOR",
                    Direction = ParameterDirection.Output,
                    OracleDbType = OracleDbType.RefCursor,
                },
            };

            return this._dataProvider.GetDatasetFromSP(SPRoutes.SP_SELLER_SEARCH, paramArr);
        }

        public DataSet Get(string SellerId)
        {
            throw new NotImplementedException();
        }

        public DataSet Get()
        {
            throw new NotImplementedException();
        }

        public ResponseMessage Update(Seller item)
        {
            throw new NotImplementedException();
        }
    }
}
