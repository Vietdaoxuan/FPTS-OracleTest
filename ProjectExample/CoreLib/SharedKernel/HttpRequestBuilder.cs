using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.SharedKernel
{
    public class HttpRequestBuilder
    {
        private readonly IConfiguration _configuration;
        private HttpMethod _method;
        private string _requestUri = string.Empty;
        private HttpContent _content;
        private string _bearerToken = string.Empty;
        private string _roleCode = string.Empty;
        private string _acceptHeader = "application/json";
        private TimeSpan _timeout = new TimeSpan(0, 0, 900);
        private bool _allowAutoRedirect = true;
        private readonly bool _isUseProxy;
        private string _proxy;

        public HttpRequestBuilder()
        {
            this._configuration = ConfigProvider.Configuration;
            try
            {
                this._isUseProxy = bool.Parse(this._configuration["ProxyConfig:UseProxy"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            this._proxy = this._configuration["ProxyConfig:ProxyAddress"];
        }

        public HttpRequestBuilder AddProxy(string proxy)
        {
            this._proxy = proxy;
            return this;
        }

        public HttpRequestBuilder AddMethod(HttpMethod method)
        {
            this._method = method;
            return this;
        }

        public HttpRequestBuilder AddRequestUri(string requestUri)
        {
            this._requestUri = requestUri;
            return this;
        }

        public HttpRequestBuilder AddContent(HttpContent content)
        {
            this._content = content;
            return this;
        }

        public HttpRequestBuilder AddBearerToken(string bearerToken)
        {
            this._bearerToken = bearerToken;
            return this;
        }

        public HttpRequestBuilder AddRoleCode(string roleCode)
        {
            this._roleCode = roleCode;
            return this;
        }

        public HttpRequestBuilder AddAcceptHeader(string acceptHeader)
        {
            this._acceptHeader = acceptHeader;
            return this;
        }

        public HttpRequestBuilder AddTimeout(TimeSpan timeout)
        {
            this._timeout = timeout;
            return this;
        }

        public HttpRequestBuilder AddAllowAutoRedirect(bool allowAutoRedirect)
        {
            this._allowAutoRedirect = allowAutoRedirect;
            return this;
        }

        public async Task<HttpResponseMessage> SendAsync()
        {
            // Check required arguments
            this.EnsureArguments();

            // Set up request
            var request = new HttpRequestMessage
            {
                Method = this._method,
                RequestUri = new Uri(this._requestUri),
            };

            if (this._content != null)
            {
                request.Content = this._content;
            }

            if (!string.IsNullOrEmpty(this._bearerToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this._bearerToken);
            }

            if (!string.IsNullOrEmpty(this._roleCode))
            {
                request.Headers.Add("RoleCode", this._roleCode);
            }

            request.Headers.Accept.Clear();
            if (!string.IsNullOrEmpty(this._acceptHeader))
            {
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(this._acceptHeader));
            }

            // Setup client
            var handler = new HttpClientHandler
            {
                AllowAutoRedirect = this._allowAutoRedirect,
                Proxy = new WebProxy(this._proxy),
                UseProxy = this._isUseProxy,
            };

            var client = new HttpClient(handler) { Timeout = this._timeout };

            return await client.SendAsync(request);
        }

        #region " Private "

        private void EnsureArguments()
        {
            if (this._method == null)
            {
                throw new ArgumentNullException("Method");
            }

            if (string.IsNullOrEmpty(this._requestUri))
            {
                throw new ArgumentNullException("Request Uri");
            }
        }

        #endregion
    }
}

