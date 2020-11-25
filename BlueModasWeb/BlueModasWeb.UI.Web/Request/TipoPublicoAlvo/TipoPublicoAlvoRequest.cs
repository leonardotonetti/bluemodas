using System.Net.Http;
using BlueModasWeb.UI.Web.Util;
using Microsoft.Extensions.Configuration;

namespace BlueModasWeb.UI.Web.Request.TipoPublicoAlvo
{
    public class TipoPublicoAlvoRequest : ITipoPublicoAlvoRequest
    {
        private readonly IConfiguration _config;

        public TipoPublicoAlvoRequest(IConfiguration config)
        {
            _config = config;
        }

        public HttpResponseMessage Get(string accessToken)
        {
            return new ApiRequestUtil(_config)
                .AddPath("api/tipoPublicoAlvo")
                .AddHeader(accessToken)
                .Get();
        }
    }
}
