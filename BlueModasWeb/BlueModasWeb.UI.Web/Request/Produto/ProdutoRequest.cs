using System.Net.Http;
using BlueModasWeb.UI.Web.Util;
using Microsoft.Extensions.Configuration;

namespace BlueModasWeb.UI.Web.Request.Produto
{
    public class ProdutoRequest : IProdutoRequest
    {
        private readonly IConfiguration _config;

        public ProdutoRequest(IConfiguration config)
        {
            _config = config;
        }

        public HttpResponseMessage Get(string accessToken, int? idTipoPublicoAlvo, int? idCategoria)
        {
            return new ApiRequestUtil(_config)
                .AddPath("api/produto")
                .AddHeader(accessToken)
                .AddParameter("idTipoPublicoAlvo", idTipoPublicoAlvo.ToString())
                .AddParameter("idCategoria", idCategoria.ToString())
                .Get();
        }
    }
}
