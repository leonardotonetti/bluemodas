using BlueModasWeb.UI.Web.Models;
using Microsoft.AspNetCore.Http;

namespace BlueModasWeb.UI.Web.Util
{
    public static class SessionUtil
    {
        public static void SetAccessToken(this ISession session, Token token)
        {
            session.SetString("AccessToken", token.AccessToken);
        }

        public static string GetAccessToken(this ISession session)
        {
            var accessToken = session.GetString("AccessToken");
            return accessToken;
        }
    }
}
