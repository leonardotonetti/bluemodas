using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace BlueModasWeb.UI.Web.Util
{
    public class ApiRequestUtil
    {
        private readonly HttpClient _httpClient;
        private readonly UriBuilder _uriBuilder;

        public ApiRequestUtil(IConfiguration config)
        {
            _httpClient = new HttpClient();
            _uriBuilder = new UriBuilder
            {
                Host = config.GetSection("BlueModasApi:Host").Value,
                Scheme = bool.Parse(config.GetSection("BlueModasApi:IsHttps").Value) ? Uri.UriSchemeHttps : Uri.UriSchemeHttp
            };

            var port = config.GetSection("BlueModasApi:Port").Value;
            if (!string.IsNullOrEmpty(port))
                _uriBuilder.Port = int.Parse(port);

        }

        public ApiRequestUtil AddPath(string path)
        {
            _uriBuilder.Path = path;
            return this;
        }

        public ApiRequestUtil AddHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return this;
        }

        public ApiRequestUtil AddParameter(string parameter, string value)
        {
            _uriBuilder.Query = $"{(!string.IsNullOrEmpty(_uriBuilder.Query) ? _uriBuilder.Query + $"&{parameter}={value}" : $"{parameter}={value}")}";
            return this;
        }

        public HttpResponseMessage Get()
        {
            return _httpClient.GetAsync(_uriBuilder.Uri).Result;
        }

        public HttpResponseMessage Post(object objectContent)
        {
            var content = JsonConvert.SerializeObject(objectContent);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return _httpClient.PostAsync(_uriBuilder.Uri, byteContent).Result;
        }

        public HttpResponseMessage Put(object objectContent)
        {
            var content = JsonConvert.SerializeObject(objectContent);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return _httpClient.PutAsync(_uriBuilder.Uri, byteContent).Result;
        }

        public HttpResponseMessage Delete()
        {
            return _httpClient.DeleteAsync(_uriBuilder.Uri).Result;
        }
    }
}
