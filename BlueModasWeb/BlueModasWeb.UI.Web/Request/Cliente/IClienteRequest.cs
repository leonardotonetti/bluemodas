using System.Net.Http;

namespace BlueModasWeb.UI.Web.Request.Cliente
{
    public interface IClienteRequest
    {
        HttpResponseMessage Get(string accessToken, string nome, string sobreNome);
    }
}
