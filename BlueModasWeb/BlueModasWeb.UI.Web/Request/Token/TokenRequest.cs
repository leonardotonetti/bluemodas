using System.Net.Http;
using BlueModasWeb.UI.Web.Util;
using Microsoft.Extensions.Configuration;

namespace BlueModasWeb.UI.Web.Request.Token
{
    public class TokenRequest : ITokenRequest
    {
        private readonly IConfiguration _config;

        public TokenRequest(IConfiguration config)
        {
            _config = config;
        }

        public HttpResponseMessage Get()
        {
            return new ApiRequestUtil(_config)
                .AddPath("api/token")
                .Get();
        }
    }
}
