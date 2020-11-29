using System;
using System.Collections.Generic;
using System.Net;
using BlueModasWeb.UI.Web.Request.Pedido;
using BlueModasWeb.UI.Web.Util;
using BlueModasWeb.UI.Web.ViewModel;
using BlueModasWeb.UI.Web.ViewModel.Pedido;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRequest _pedidoRequest;

        public PedidoController(IPedidoRequest pedidoRequest)
        {
            _pedidoRequest = pedidoRequest;
        }

        public IActionResult Confirmar(PedidoViewModel pedido)
        {
            try
            {
                var accessToken = HttpContext.Session.GetAccessToken();
                if (accessToken == null)
                    RedirectToAction("GetAccessToken", "Token");

                var pedidoRequest = _pedidoRequest.Post(accessToken, pedido);
                if (!pedidoRequest.IsSuccessStatusCode)
                {
                    var errorContent = JsonConvert.DeserializeObject<IEnumerable<ErrorViewModel>>(pedidoRequest.Content.ReadAsStringAsync().Result);
                    return StatusCode((int)pedidoRequest.StatusCode, errorContent);
                }

                var pedidoViewModel = JsonConvert.DeserializeObject<PedidoViewModel>(pedidoRequest.Content.ReadAsStringAsync().Result);

                return View(pedidoViewModel);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
