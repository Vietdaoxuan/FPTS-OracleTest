using CoreLib.Config;
using CoreLib.Entities;
using CoreLib.Interfaces;
using CoreLib.SharedKernel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Services
{
    public class HttpServices : IHttpServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IErrorHandler _errorHandler;
        private readonly string _requestFailMessage = "REQUEST_UNSUCCESSFUL";

        /// <summary>
        /// Role code của controller hiện tại , truyền vào header.
        /// </summary>
        private string _roleCodeController;

        public HttpServices(IHttpContextAccessor httpContextAccessor, IErrorHandler errorHandler)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._errorHandler = errorHandler;
        }

        /// <inheritdoc/>
        public void SetRoleControllerToHeader(string roleCode)
        {
            this._roleCodeController = roleCode;
        }

        public async Task<DataSet> FetchDataSetFromGetUrl(string requestUri)
        {
            try
            {
                var response = await HttpRequestFactory.Get(requestUri, this._httpContextAccessor.HttpContext.Session.GetString(SessionTypes.TOKEN), this._roleCodeController);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<DataSet>(await response.Content.ReadAsStringAsync());
            }
            catch (HttpRequestException e)
            {
                this._errorHandler.WriteToFile(e);
                return new DataSet();
            }
        }

        public async Task<DataTable> FetchDataTableFromGetUrl(string requestUri)
        {
            var dataset = await this.FetchDataSetFromGetUrl(requestUri);
            if (dataset.Tables.Count == 0)
            {
                return new DataTable();
            }

            return dataset.Tables[0];
        }

        public async Task<DataRow> FetchDataRowFromGetUrl(string requestUri)
        {
            var dataTable = await this.FetchDataTableFromGetUrl(requestUri);
            if (dataTable.Rows.Count == 0)
            {
                return dataTable.NewRow();
            }

            return dataTable.Rows[0];
        }

        public async Task<ResponseMessage> ResponseMessageFromGetUrl(string requestUri)
        {
            try
            {
                var response = await HttpRequestFactory.Get(requestUri, this._httpContextAccessor.HttpContext.Session.GetString(SessionTypes.TOKEN), this._roleCodeController);
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception e)
            {
                this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public async Task<DataSet> FetchDataSetFromPostUrl(string requestUri, object data)
        {
            try
            {
                var response = await HttpRequestFactory.Post(requestUri, data, this._httpContextAccessor.HttpContext.Session.GetString(SessionTypes.TOKEN), this._roleCodeController);
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<DataSet>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception e)
            {
                this._errorHandler.WriteToFile(e);
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
                var response = await HttpRequestFactory.Post(requestUri, data, this._httpContextAccessor.HttpContext.Session.GetString(SessionTypes.TOKEN), this._roleCodeController);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public async Task<ResponseMessage> ResponseMessageFromPutUrl(string requestUri, object data)
        {
            try
            {
                var response = await HttpRequestFactory.Put(requestUri, data, this._httpContextAccessor.HttpContext.Session.GetString(SessionTypes.TOKEN), this._roleCodeController);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public async Task<ResponseMessage> ResponseMessageFromDeleteUrl(string requestUri)
        {
            try
            {
                var response = await HttpRequestFactory.Delete(requestUri, this._httpContextAccessor.HttpContext.Session.GetString(SessionTypes.TOKEN), this._roleCodeController);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ResponseMessage>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                this._errorHandler.WriteToFile(e);
            }

            return new ResponseMessage("-1", this._requestFailMessage);
        }

        public Task FetchDataTableFromGetUrl(object p)
        {
            throw new NotImplementedException();
        }
    }
}
