using System.Net.Http;

namespace BlueModasWeb.UI.Web.Request.TipoPublicoAlvo
{
    public interface ITipoPublicoAlvoRequest
    {
        HttpResponseMessage Get(string accessToken);
    }
}
