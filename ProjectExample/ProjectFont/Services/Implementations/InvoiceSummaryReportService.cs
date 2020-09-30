using CommonLib.Interfaces;
using Microsoft.Extensions.Configuration;
using ProjectFont.AppCodes.CallAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Services.Implementations
{
    public class InvoiceSummaryReportService
    {
        private readonly IHttpService _httpService;
        private readonly IConfiguration _configuration;
        private readonly string _BaseUri;
        private readonly ICommon _common;

        public InvoiceSummaryReportService(IHttpService httpService, IConfiguration configuration, ICommon common)
        {
            this._httpService = httpService;
            this._configuration = configuration;
            this._common = common;
            this._BaseUri = this._configuration["ApiUrl"];
        }

      

    }
}
