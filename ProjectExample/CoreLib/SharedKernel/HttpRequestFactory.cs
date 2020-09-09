using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.SharedKernel
{
    public class HttpRequestFactory
    {
        public static async Task<HttpResponseMessage> Get(string requestUri)
            => await Get(requestUri, string.Empty);

        /// <summary>
        ///
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="bearerToken">JWT token.</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> Get(string requestUri, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Get)
                                .AddRequestUri(requestUri)
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(string requestUri, object value)
            => await Post(requestUri, value, string.Empty);

        public static async Task<HttpResponseMessage> Post(
            string requestUri, object value, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value))
                                .AddBearerToken(bearerToken)
                                ;

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(string requestUri, object value)
            => await Put(requestUri, value, string.Empty);

        public static async Task<HttpResponseMessage> Put(string requestUri, object value, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Put)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Patch(string requestUri, object value)
            => await Patch(requestUri, value, string.Empty);

        public static async Task<HttpResponseMessage> Patch(
            string requestUri, object value, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(new HttpMethod("PATCH"))
                                .AddRequestUri(requestUri)
                                .AddContent(new PatchContent(value))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Delete(string requestUri)
            => await Delete(requestUri, string.Empty);

        public static async Task<HttpResponseMessage> Delete(
            string requestUri, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Delete)
                                .AddRequestUri(requestUri)
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> PostFile(
            string requestUri,
            string filePath, string apiParamName)
            => await PostFile(requestUri, filePath, apiParamName, string.Empty);

        public static async Task<HttpResponseMessage> PostFile(
            string requestUri,
            string filePath, string apiParamName, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .AddContent(new FileContent(filePath, apiParamName))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        // request with role code
        //
        public static async Task<HttpResponseMessage> Get(string requestUri, string bearerToken, string roleCode)
        {
            var builder = new HttpRequestBuilder()
                .AddMethod(HttpMethod.Get)
                .AddRequestUri(requestUri)
                .AddBearerToken(bearerToken)
                .AddRoleCode(roleCode);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(
            string requestUri, object value, string bearerToken, string roleCode)
        {
            var builder = new HttpRequestBuilder()
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddContent(new JsonContent(value))
                .AddBearerToken(bearerToken)
                .AddRoleCode(roleCode);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(
            string requestUri, object value, string bearerToken, string roleCode)
        {
            var builder = new HttpRequestBuilder()
                .AddMethod(HttpMethod.Put)
                .AddRequestUri(requestUri)
                .AddContent(new JsonContent(value))
                .AddBearerToken(bearerToken)
                .AddRoleCode(roleCode);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Delete(
           string requestUri, string bearerToken, string roleCode)
        {
            var builder = new HttpRequestBuilder()
                .AddMethod(HttpMethod.Delete)
                .AddRequestUri(requestUri)
                .AddBearerToken(bearerToken)
                .AddRoleCode(roleCode);

            return await builder.SendAsync();
        }
    }
}
