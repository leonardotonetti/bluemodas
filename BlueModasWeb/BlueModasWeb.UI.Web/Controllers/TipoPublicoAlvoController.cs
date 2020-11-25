using System;
using System.Collections.Generic;
using System.Net;
using BlueModasWeb.UI.Web.Models;
using BlueModasWeb.UI.Web.Request.TipoPublicoAlvo;
using BlueModasWeb.UI.Web.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class TipoPublicoAlvoController : Controller
    {
        private readonly ITipoPublicoAlvoRequest _tipoPublicoAlvoRequest;

        public TipoPublicoAlvoController(ITipoPublicoAlvoRequest tipoPublicoAlvoRequest)
        {
            _tipoPublicoAlvoRequest = tipoPublicoAlvoRequest;
        }

        public IActionResult TipoPublicoAlvoDropDownList()
        {
            try
            {
                var accessToken = HttpContext.Session.GetAccessToken();
                if (accessToken == null)
                    RedirectToAction("GetAccessToken", "Token");

                var tipoPublicoAlvoRequest = _tipoPublicoAlvoRequest.Get(accessToken);
                if (!tipoPublicoAlvoRequest.IsSuccessStatusCode)
                    return StatusCode((int)HttpStatusCode.InternalServerError);

                var tipoPublicoAlvo = JsonConvert.DeserializeObject<IEnumerable<TipoPublicoAlvo>>(tipoPublicoAlvoRequest.Content.ReadAsStringAsync().Result);

                return PartialView("_TipoPublicoAlvoDropDownList", tipoPublicoAlvo);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
