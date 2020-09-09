using CoreLib.Entities;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces
{
    public interface ICBaseDataProvider
    {
        void SetRoleCode(string roleCode);

        void SetUsername(string username);

        DataSet GetDatasetFromSP(string SPname, OracleParameter[] paramArr);

        DataTable GetDataTableFromSP(string SPname, OracleParameter[] paramArr);

        DataRow GetDataRowFromSP(string SPname, OracleParameter[] paramArr);

        bool ExecuteSP(string SPname, OracleParameter[] paramArr);

        /// <summary>
        /// Thực thi sp ,
        /// SP tryền vào phải có 2 output parameter ,
        ///  @Message  nvarchar(200) output ,
        ///  @ErrorCode int output.
        /// </summary>
        /// <param name="SPname">Tên SP.</param>
        /// <param name="paramArr">Các para chứa dữ liệu.</param>
        /// <returns>Respose gồm mã lỗi và message. </returns>
        ResponseMessage GetResponseFromExecutedSP(string SPname, OracleParameter[] paramArr);
    }
}
