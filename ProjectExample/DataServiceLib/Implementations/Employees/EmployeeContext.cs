using CoreLib.Config;
using CoreLib.Entities;
using CoreLib.Interfaces;
using DataServiceLib.Interfaces;
using DataServiceLib.Interfaces.Employees;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Implementations.Employees
{
    public class EmployeeContext : IEmployeeContext
    {
        private readonly ICBaseDataProvider _dataProvider;        

        public EmployeeContext(ICBaseDataProvider dataProvider)
        {
            this._dataProvider = dataProvider;            
        }

        /// <inheritdoc/>
        public DataSet Get(Employee searchOptions)
        {
            var paramArr = new[]
            {
                new OracleParameter()
                {
                    ParameterName = "pEmp_ID",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.EmployeeID,
                },
                new OracleParameter()
                {
                    ParameterName = "pLast_Name",
                    Direction = ParameterDirection.Input,
                    OracleDbType = OracleDbType.Varchar2,
                    Value = searchOptions.LastName,
                },
                new OracleParameter()
                {
                    ParameterName = "p_cur",
                    Direction = ParameterDirection.Output,
                    OracleDbType = OracleDbType.RefCursor,
                },
            };

            return this._dataProvider.GetDatasetFromSP(SPRoutes.SP_HUONGVU_SEARCH_EMPLOYEES, paramArr);
        }

        /// <inheritdoc/>
        public DataSet Get(string employeeID)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public DataSet Get()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ResponseMessage Add(Employee item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ResponseMessage Delete(string employeeID)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ResponseMessage Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
