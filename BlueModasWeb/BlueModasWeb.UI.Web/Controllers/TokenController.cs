using System;
using System.Net;
using BlueModasWeb.UI.Web.Models;
using BlueModasWeb.UI.Web.Request.Token;
using BlueModasWeb.UI.Web.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class TokenController : ControllerBase
    {
        private readonly ITokenRequest _tokenRequest;

        public TokenController(ITokenRequest tokenRequest)
        {
            _tokenRequest = tokenRequest;
        }

        public IActionResult GetAccessToken()
        {
            try
            {
                var tokenRequest = _tokenRequest.Get();
                if (!tokenRequest.IsSuccessStatusCode)
                    return StatusCode((int)HttpStatusCode.InternalServerError);

                var token = JsonConvert.DeserializeObject<Token>(tokenRequest.Content.ReadAsStringAsync().Result);
                HttpContext.Session.SetAccessToken(token);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
