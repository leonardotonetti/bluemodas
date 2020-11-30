using System.Net.Http;
using BlueModasWeb.UI.Web.Util;
using Microsoft.Extensions.Configuration;

namespace BlueModasWeb.UI.Web.Request.Cliente
{
    public class ClienteRequest : IClienteRequest
    {
        private readonly IConfiguration _config;

        public ClienteRequest(IConfiguration config)
        {
            _config = config;
        }

        public HttpResponseMessage Get(string accessToken, string nome, string sobreNome)
        {
            return new ApiRequestUtil(_config)
                .AddPath("api/cliente")
                .AddHeader(accessToken)
                .AddParameter("nome", nome)
                .AddParameter("sobreNome", sobreNome)
                .Get();
        }
    }
}
