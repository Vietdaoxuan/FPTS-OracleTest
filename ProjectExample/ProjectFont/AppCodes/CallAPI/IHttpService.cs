using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.AppCodes.CallAPI
{
    public interface IHttpService
    {
        void SetRoleControllerToHeader(string roleCode);

        // HTTP GET
        Task<DataSet> FetchDataSetFromGetUrl(string requestUri);

        Task<DataTable> FetchDataTableFromGetUrl(string requestUri);

        Task<DataRow> FetchDataRowFromGetUrl(string requestUri);

        Task<ResponseMessage> ResponseMessageFromGetUrl(string requestUri);

        // HTTP POST
        Task<DataSet> FetchDataSetFromPostUrl(string requestUri, object data);

        Task<DataTable> FetchDataTableFromPostUrl(string requestUri, object data);

        Task<DataRow> FetchDataRowFromPostUrl(string requestUri, object data);

        Task<ResponseMessage> ResponseMessageFromPostUrl(string requestUri, object data);

        // HTTP PUT
        Task<ResponseMessage> ResponseMessageFromPutUrl(string requestUri, object data);

        // HTTP DELETE
        Task<ResponseMessage> ResponseMessageFromDeleteUrl(string requestUri);
    }
}
