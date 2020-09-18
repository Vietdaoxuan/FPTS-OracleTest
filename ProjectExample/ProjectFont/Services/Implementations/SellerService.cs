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
    public class SellerService : ISellerService
    {
        private readonly IHttpService _httpService;
        private readonly IConfiguration _configuration;
        private readonly string _BaseUri;
        private readonly ICommon _common;

        public SellerService(IHttpService httpService, IConfiguration configuration, ICommon common)
        {
            this._httpService = httpService;
            this._configuration = configuration;
            this._common = common;
            this._BaseUri = this._configuration["ApiUrl"];
        }
        public async Task<IEnumerable<Seller>> Get(Seller searchOptions)
        {
            var dataTable = await this._httpService.FetchDataTableFromGetUrl(this._configuration["ApiUrl"] + ApiRoute.Sellers + "?" + this._common.ToQueryString(searchOptions));

            var mapper = new DataNamesMapper<Seller>();
            return mapper.Map(dataTable);
        }
    }
}
