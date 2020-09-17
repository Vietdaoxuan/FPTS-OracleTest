using CoreLib.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProjectFont.AppCodes.CallAPI
{
    public class CallAPIService
    {
        #region snippet_HttpClient

        public static HttpClient client = new HttpClient();        
        public static string APILINK = "http://localhost:52739";

        //private readonly IConfiguration _config;
        //public CallAPIService(IConfiguration config)
        //{
        //    this._config = config;
        //   //APILINK = this._config["ApiUrl"];
        //}

        #endregion snippet_HttpClient

        private static void Unit()
        {
            try
            {
                client.BaseAddress = new Uri(APILINK);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        // Call api Post Method
        public static async Task<ResponseMessage> PostTemplateAsync(Object obj, string LinkAPI)
        {
            Unit();
            ResponseMessage responseMessage = new ResponseMessage();
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(LinkAPI, obj);
                if (response.IsSuccessStatusCode)
                {
                    responseMessage = await response.Content.ReadAsAsync<ResponseMessage>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return responseMessage;
        }

        // Call api Put Method
        public static async Task<ResponseMessage> PutTemplateAsync(Object temp, string LinkAPI)
        {
            Unit();
            ResponseMessage responseMessage = new ResponseMessage();
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(LinkAPI, temp);
                if (response.IsSuccessStatusCode)
                {
                    responseMessage = await response.Content.ReadAsAsync<ResponseMessage>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return responseMessage;
        }

        // Call api Delete Method
        public static async Task<ResponseMessage> DeleteTemplateAsync(string LinkAPI)
        {
            Unit();
            ResponseMessage responseMessage = new ResponseMessage();

            try
            {
                HttpResponseMessage response = await client.DeleteAsync(LinkAPI);
                if (response.IsSuccessStatusCode)
                {
                    responseMessage = await response.Content.ReadAsAsync<ResponseMessage>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return responseMessage;
        }

        // Call api Get Method (Search)
        public static async Task<Object> SearchTemplateAsync(string LinkAPI)
        {
            Unit();
            Object obj = new Object();
            try
            {
                HttpResponseMessage response = await client.GetAsync(LinkAPI);

                if (response.IsSuccessStatusCode)
                {
                    obj = await response.Content.ReadAsAsync<Object>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return obj;
        }

        // Call api Get Method (Get all)
        public static async Task<List<Object>> GetTemplateAsync(string LinkAPI)
        {
            Unit();
            List<Object> obj = new List<Object>();
            try
            {
                HttpResponseMessage response = await client.GetAsync(LinkAPI);

                if (response.IsSuccessStatusCode)
                {
                    obj = await response.Content.ReadAsAsync<List<Object>>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return obj;
        }

        /// <summary>
        /// GetDataTableTemplateAsync
        /// </summary>
        /// <param name="LinkAPI"></param>
        /// <returns>Datatable</returns>
        public static async Task<DataTable> GetDataTableTemplateAsync(string LinkAPI)
        {
            Unit();

            try
            {
                var response = await client.GetAsync(LinkAPI);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<DataTable>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return new DataTable();
        }

        public static async Task<ResponseMessage> GetCResultTemplateAsync(string LinkAPI)
        {
            Unit();
            ResponseMessage obj = new ResponseMessage();
            try
            {
                HttpResponseMessage response = await client.GetAsync(LinkAPI);

                if (response.IsSuccessStatusCode)
                {
                    obj = await response.Content.ReadAsAsync<ResponseMessage>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return obj;
        }

        public static async Task<String> GetStringTemplateAsync(string LinkAPI)
        {
            Unit();

            try
            {
                var response = await client.GetAsync(LinkAPI);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //return (await response.Content.ReadAsStringAsync(string));
                    return await response.Content.ReadAsAsync<string>();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return "";
        }
    }
}
