using System;
using System.Collections.Generic;
using System.Net;
using BlueModasWeb.UI.Web.Models;
using BlueModasWeb.UI.Web.Request.Cliente;
using BlueModasWeb.UI.Web.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRequest _clienteRequest;

        public ClienteController(IClienteRequest clienteRequest)
        {
            _clienteRequest = clienteRequest;
        }

        public IActionResult Cliente(string nome, string sobreNome)
        {
            try
            {
                var accessToken = HttpContext.Session.GetAccessToken();
                if (accessToken == null)
                    RedirectToAction("GetAccessToken", "Token");

                var clienteRequest = _clienteRequest.Get(accessToken, nome, sobreNome);
                if (!clienteRequest.IsSuccessStatusCode)
                    return StatusCode((int)HttpStatusCode.InternalServerError);

                var cliente = JsonConvert.DeserializeObject<Cliente>(clienteRequest.Content.ReadAsStringAsync().Result);

                return new JsonResult(cliente);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
