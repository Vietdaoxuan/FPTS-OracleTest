using CoreLib.Config;
using CoreLib.Entities;
using CoreLib.Interfaces;
using CoreLib.SharedKernel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.AppCodes.CallAPI
{
    public class HttpService : IHttpService
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _requestFailMessage = "REQUEST_UNSUCCESSFUL";

        /// <summary>
        /// Role code của controller hiện tại , truyền vào header.
        /// </summary>
        private string _roleCodeController;

        // Constructor
        public HttpService()//IHttpContextAccessor httpContextAccessor
        {
            //this._httpContextAccessor = httpContextAccessor;
        }

        // get data from DataSet
        public async Task<DataSet> FetchDataSetFromGetUrl(string requestUri)
        {
            try
            {
                var response = await HttpRequestFactory.Get(requestUri);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<DataSet>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception e)
            {
                ////this._errorHandler.WriteToFile(e);
            }

            return new DataSet();
        }

        // get data from DataTable
        public async Task<DataTable> FetchDataTableFromGetUrl(string requestUri)
        {
            var dataset = await this.FetchDataSetFromGetUrl(requestUri);
            return dataset.Tables.Count == 0 ? new DataTable() : dataset.Tables[0];
        }

        //// get data from DataRow
        public async Task<DataRow> FetchDataRowFromGetUrl(string requestUri)
        {
            var dataTable = await this.FetchDataTableFromGetUrl(requestUri);
            if (dataTable.Rows.Count == 0)
            {
                return dataTable.NewRow();
            }

            return dataTable.Rows[0];
        }

        // // get data from DataSet 
        public async Task<ResponseMessage> ResponseMessageFromGetUrl(string requestUri)
        {
            try
            {
                var response = await HttpRequestFactory.Get(requestUri);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception e)
            {
                //this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public async Task<DataSet> FetchDataSetFromPostUrl(string requestUri, object data)
        {
            try
            {
                var response = await HttpRequestFactory.Post(requestUri, data);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<DataSet>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception e)
            {
                //this._errorHandler.WriteToFile(e);
            }

            return new DataSet();
        }

        public async Task<DataTable> FetchDataTableFromPostUrl(string requestUri, object data)
        {
            var dataset = await this.FetchDataSetFromPostUrl(requestUri, data);
            return dataset.Tables.Count == 0 ? new DataTable() : dataset.Tables[0];
        }

        public async Task<DataRow> FetchDataRowFromPostUrl(string requestUri, object data)
        {
            var dataTable = await this.FetchDataTableFromPostUrl(requestUri, data);
            return dataTable.Rows.Count == 0 ? dataTable.NewRow() : dataTable.Rows[0];
        }

        public async Task<ResponseMessage> ResponseMessageFromPostUrl(string requestUri, object data)
        {
            try
            {
                var response = await HttpRequestFactory.Post(requestUri, data);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                //this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public async Task<ResponseMessage> ResponseMessageFromPutUrl(string requestUri, object data)
        {
            try
            {
                var response = await HttpRequestFactory.Put(requestUri, data);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                //this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public async Task<ResponseMessage> ResponseMessageFromDeleteUrl(string requestUri)
        {
            try
            {
                var response = await HttpRequestFactory.Delete(requestUri);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                //this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public void SetRoleControllerToHeader(string roleCode)
        {
            throw new NotImplementedException();
        }
    }
}
