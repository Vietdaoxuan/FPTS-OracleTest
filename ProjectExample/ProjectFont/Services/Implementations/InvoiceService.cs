using CommonLib.Interfaces;
using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using Microsoft.Extensions.Configuration;
using ProjectFont.AppCodes.CallAPI;
using ProjectFont.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Services.Implementations
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IHttpService _httpService;
        private readonly IConfiguration _configuration;
        private readonly string _BaseUri;
        private readonly ICommon _common;

        public InvoiceService(IHttpService httpService, IConfiguration configuration, ICommon common)
        {
            this._httpService = httpService;
            this._configuration = configuration;
            this._common = common;
            this._BaseUri = this._configuration["ApiUrl"];
        }

        public Task<ResponseMessage> Add(Invoice group)
        {
            return this._httpService.ResponseMessageFromPostUrl(this._BaseUri + ApiRoute.InsertInvoices, group);
        }

        public Task<ResponseMessage> Delete(int invoiceID)
        {
            return this._httpService.ResponseMessageFromDeleteUrl(this._configuration["ApiUrl"] + ApiRoute.DeleteInvoices + "?invoiceID=" + invoiceID);
        }

        public async Task<IEnumerable<Invoice>> Get(Invoice searchOptions)
        {
            var dataTable = await this._httpService.FetchDataTableFromGetUrl(this._configuration["ApiUrl"] + ApiRoute.InvoicesDataSet + "?" + this._common.ToQueryString(searchOptions));

            var mapper = new DataNamesMapper<Invoice>();
            return mapper.Map(dataTable);
        }

        public Task<Invoice> Get(int invoiceID)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessage> Update(Invoice group)
        {
            return this._httpService.ResponseMessageFromPutUrl(this._BaseUri + ApiRoute.UpdateInvoices, group);
        }
    }
}
