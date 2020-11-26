using System.Net.Http;

namespace BlueModasWeb.UI.Web.Request.Produto
{
    public interface IProdutoRequest
    {
        HttpResponseMessage Get(string accessToken, int? idTipoPublicoAlvo, int? idCategoria);
    }
}
