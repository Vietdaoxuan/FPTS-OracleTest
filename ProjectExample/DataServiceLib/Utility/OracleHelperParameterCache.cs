using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Utility
{
    public sealed class OracleHelperParameterCache
    {
        private static readonly Hashtable ParamCache = Hashtable.Synchronized(new Hashtable());
        #region private methods, variables, and constructors

        // Since this class provides only static methods, make the default constructor private to prevent
        // instances from being created with "new OracleHelperParameterCache()".
        private OracleHelperParameterCache()
        {
        }

        /// <summary>
        /// resolve at run-time the appropriate set of OracleParameters for a stored procedure.
        /// </summary>
        /// <param name="connectionString">a valid connection string for an OracleConnection.</param>
        /// <param name="spName">the name of the stored procedure.</param>
        /// <param name="includeReturnValueParameter">whether or not to include ther return value parameter.</param>
        /// <returns></returns>
        private static OracleParameter[] DiscoverSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            using (OracleConnection cn = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(spName, cn))
            {
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                OracleCommandBuilder.DeriveParameters(cmd);

                if (!includeReturnValueParameter)
                {
                    if (ParameterDirection.ReturnValue == cmd.Parameters[0].Direction)
                    {
                        cmd.Parameters.RemoveAt(0);
                    }
                }

                OracleParameter[] discoveredParameters = new OracleParameter[cmd.Parameters.Count];

                cmd.Parameters.CopyTo(discoveredParameters, 0);

                return discoveredParameters;
            }
        }

        // deep copy of cached OracleParameter array
        private static OracleParameter[] CloneParameters(OracleParameter[] originalParameters)
        {
            OracleParameter[] clonedParameters = new OracleParameter[originalParameters.Length];

            for (int i = 0, j = originalParameters.Length; i < j; i++)
            {
                clonedParameters[i] = (OracleParameter)((ICloneable)originalParameters[i]).Clone();
            }

            return clonedParameters;
        }

        #endregion private methods, variables, and constructors

        #region caching functions

        /// <summary>
        /// add parameter array to the cache.
        /// </summary>
        /// <param name="connectionString">a valid connection string for an OracleConnection.</param>
        /// <param name="commandText">the stored procedure name or T-OleDb command.</param>
        /// <param name="commandParameters">an array of OracleParameters to be cached.</param>
        public static void CacheParameterSet(string connectionString, string commandText, params OracleParameter[] commandParameters)
        {
            string hashKey = connectionString + ":" + commandText;

            ParamCache[hashKey] = commandParameters;
        }

        /// <summary>
        /// retrieve a parameter array from the cache.
        /// </summary>
        /// <param name="connectionString">a valid connection string for an OracleConnection.</param>
        /// <param name="commandText">the stored procedure name or T-OleDb command.</param>
        /// <returns>an array of OracleParameters.</returns>
        public static OracleParameter[] GetCachedParameterSet(string connectionString, string commandText)
        {
            string hashKey = connectionString + ":" + commandText;

            OracleParameter[] cachedParameters = (OracleParameter[])ParamCache[hashKey];

            if (cachedParameters == null)
            {
                return null;
            }
            else
            {
                return CloneParameters(cachedParameters);
            }
        }

        #endregion caching functions

        #region Parameter Discovery Functions

        /// <summary>
        /// Retrieves the set of OracleParameters appropriate for the stored procedure.
        /// </summary>
        /// <remarks>
        /// This method will query the database for this information, and then store it in a cache for future requests.
        /// </remarks>
        /// <param name="connectionString">a valid connection string for an OracleConnection.</param>
        /// <param name="spName">the name of the stored procedure.</param>
        /// <returns>an array of OracleParameters.</returns>
        public static OracleParameter[] GetSpParameterSet(string connectionString, string spName)
        {
            return GetSpParameterSet(connectionString, spName, false);
        }

        /// <summary>
        /// Retrieves the set of OracleParameters appropriate for the stored procedure.
        /// </summary>
        /// <remarks>
        /// This method will query the database for this information, and then store it in a cache for future requests.
        /// </remarks>
        /// <param name="connectionString">a valid connection string for an OracleConnection.</param>
        /// <param name="spName">the name of the stored procedure.</param>
        /// <param name="includeReturnValueParameter">a bool value indicating whether the return value parameter should be included in the results.</param>
        /// <returns>an array of OracleParameters.</returns>
        public static OracleParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            string hashKey = connectionString + ":" + spName + (includeReturnValueParameter ? ":include ReturnValue Parameter" : string.Empty);

            OracleParameter[] cachedParameters;

            cachedParameters = (OracleParameter[])ParamCache[hashKey];

            if (cachedParameters == null)
            {
                cachedParameters = (OracleParameter[])(ParamCache[hashKey] = DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter));
            }

            return CloneParameters(cachedParameters);
        }

        #endregion Parameter Discovery Functions

    }
}
