using System.Net.Http;
using BlueModasWeb.UI.Web.ViewModel.Pedido;

namespace BlueModasWeb.UI.Web.Request.Pedido
{
    public interface IPedidoRequest
    {
        HttpResponseMessage Post(string accessToken, PedidoViewModel pedido);
    }
}
