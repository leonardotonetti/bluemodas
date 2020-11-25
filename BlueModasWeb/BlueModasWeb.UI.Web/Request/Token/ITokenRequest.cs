using System.Net.Http;

namespace BlueModasWeb.UI.Web.Request.Token
{
    public interface ITokenRequest
    {
        HttpResponseMessage Get();
    }
}
