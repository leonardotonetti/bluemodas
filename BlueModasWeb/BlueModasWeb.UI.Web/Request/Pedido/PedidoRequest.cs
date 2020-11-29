using System.Net.Http;
using BlueModasWeb.UI.Web.Util;
using BlueModasWeb.UI.Web.ViewModel.Pedido;
using Microsoft.Extensions.Configuration;

namespace BlueModasWeb.UI.Web.Request.Pedido
{
    public class PedidoRequest : IPedidoRequest
    {
        private readonly IConfiguration _config;

        public PedidoRequest(IConfiguration config)
        {
            _config = config;
        }

        public HttpResponseMessage Post(string accessToken, PedidoViewModel pedido)
        {
            return new ApiRequestUtil(_config)
                .AddPath("api/pedido")
                .AddHeader(accessToken)
                .Post(pedido);
        }
    }
}
