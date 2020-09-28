using CoreLib.Entities;
using CoreLib.Interfaces;
using DataServiceLib.Interfaces;
using DataServiceLib.Utility;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace DataServiceLib.Implementations
{
    public class CBaseDataProvider : ICBaseDataProvider
    {
        private readonly IConfiguration _config;
        private readonly IErrorHandler _errorHandler;
        private readonly string _connectionString;
        private List<OracleParameter> _requiredParams;

        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

        /// <summary>
        /// Initializes a new instance of the <see cref="CBaseDataProvider"/> class.
        /// </summary>
        /// <param name="config"></param>
        public CBaseDataProvider(IConfiguration config)
        {
            this._config = config;
            //this._connectionString = this.configuration["ConnectionString"];
            this._connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.26.7.23)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=tradingt)));User Id = study; Password = study123;";
            this._requiredParams = new List<OracleParameter>();
        }

        /// <inheritdoc/>
        public void SetRoleCode(string roleCode)
        {
            if (!string.IsNullOrEmpty(roleCode))
            {
                this._requiredParams.Add(new OracleParameter
                {
                    ParameterName = "p_RoleCode",
                    OracleDbType = OracleDbType.Varchar2,
                    Direction = ParameterDirection.Input,
                    Value = roleCode,
                });
            }
        }

        /// <inheritdoc/>
        public void SetUsername(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                this._requiredParams.Add(new OracleParameter
                {
                    ParameterName = "p_USERNAME",
                    OracleDbType = OracleDbType.Varchar2,
                    Direction = ParameterDirection.Input,
                    Value = username,
                });
            }
        }

        /// <inheritdoc/>
        public DataSet GetDatasetFromSP(string spName, OracleParameter[] paramArr)
        {
            try
            {
                //ConvertspNameToLog(spName, paramArr); // Ghi log đầu vào
                var paramList = paramArr.ToList();
                if (this._requiredParams.Count > 0)
                {
                    this._requiredParams.ForEach(param => { paramList.Add(param); });

                    // sau khi add thì clear luôn , set chỉ dùng 1 lần
                    this._requiredParams.Clear();
                }

                paramArr = paramList.ToArray();
                return OracleHelper.ExecuteDataset(this._connectionString, CommandType.StoredProcedure, spName, paramArr);
            }
            catch (Exception e)
            {
                //this._errorHandler.WriteToFile(e);
                e.ToString();
            }

            return new DataSet();
        }

        /// <inheritdoc/>
        public DataTable GetDataTableFromSP(string spName, OracleParameter[] paramArr)
        {
            //ConvertspNameToLog(spName, paramArr); // Ghi log đầu vào
            var dsData = this.GetDatasetFromSP(spName, paramArr);
            if (dsData.Tables.Count > 0)
            {
                return dsData.Tables[0];
            }

            return null;
        }

        /// <inheritdoc/>
        public DataRow GetDataRowFromSP(string spName, OracleParameter[] paramArr)
        {
            //ConvertspNameToLog(spName, paramArr); // Ghi log đầu vào
            var dtbData = this.GetDataTableFromSP(spName, paramArr);
            if (dtbData.Rows.Count > 0)
            {
                return dtbData.Rows[0];
            }

            return null;
        }

        /// <inheritdoc/>
        public bool ExecuteSP(string spName, OracleParameter[] paramArr)
        {
            //ConvertspNameToLog(spName, paramArr); // Ghi log đầu vào
            var paramList = paramArr.ToList();
            if (this._requiredParams.Count > 0)
            {
                this._requiredParams.ForEach(param => { paramList.Add(param); });

                // sau khi add thì clear luôn , set chỉ dùng 1 lần
                this._requiredParams.Clear();
            }

            paramArr = paramList.ToArray();

            return OracleHelper.ExecuteNonQuery(this._connectionString, CommandType.StoredProcedure, spName, paramArr) > 0;
        }

        /// <summary>
        /// SP phải có 2 param p_MESSAGE và p_ERRORCODE.
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="paramArr"></param>
        /// <returns></returns>
        public ResponseMessage GetResponseFromExecutedSP(string spName, OracleParameter[] paramArr)
        {
            var errorCode = new OracleParameter()
            {
                ParameterName = "p_ERRORCODE",
                OracleDbType = OracleDbType.Int32,
                Size = 25,
                Direction = ParameterDirection.Output,
            };
            var message = new OracleParameter()
            {
                ParameterName = "p_MESSAGE",
                OracleDbType = OracleDbType.Varchar2,
                Size = 200,
                Direction = ParameterDirection.Output,
            };

            var paramList = paramArr.ToList();
            paramList.Add(message);
            paramList.Add(errorCode);

            if (this._requiredParams.Count > 0)
            {
                this._requiredParams.ForEach(param => { paramList.Add(param); });

                // sau khi add thì clear luôn , set chỉ dùng 1 lần
                this._requiredParams.Clear();
            }

            //ConvertspNameToLog(spName, paramArr); // Ghi log đầu vào
            paramArr = paramList.ToArray();
            try
            {
                this.ExecuteSP(spName, paramArr);

                if (errorCode.Value != null && message.Value != null)
                {
                    return new ResponseMessage()
                    {
                        Code = errorCode.Value.ToString(),
                        Message = message.Value.ToString(),
                    };
                }

                return new ResponseMessage("-1", "Không thể thực thi SP");
            }
            catch (Exception e)
            {
                // this._errorHandler.WriteToFile(e);

                return new ResponseMessage("-1", e.Message);
            }
        }

        /// <summary>
        /// Ghi log tên sp và chuỗi đầu vào
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="paramArr"></param>
        public static void ConvertspNameToLog(string spName, OracleParameter[] paramArr)
        {
            try
            {
                string stringParam = "";
                foreach (OracleParameter re in paramArr)
                {
                    stringParam += re.ParameterName + ":" + re.Value + ";";
                }
                //this._errorHandler.WriteStringToFile(spName, Stringparam);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
    }
}
