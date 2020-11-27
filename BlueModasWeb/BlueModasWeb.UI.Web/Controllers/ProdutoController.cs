using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using BlueModasWeb.UI.Web.Models;
using BlueModasWeb.UI.Web.Request.Produto;
using BlueModasWeb.UI.Web.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRequest _produtoRequest;

        public ProdutoController(IProdutoRequest produtoRequest)
        {
            _produtoRequest = produtoRequest;
        }

        public IActionResult Produtos(int? idTipoPublicoAlvo, int? idCategoria)
        {
            try
            {
                var accessToken = HttpContext.Session.GetAccessToken();
                if (accessToken == null)
                    RedirectToAction("GetAccessToken", "Token");

                var produtoRequest = _produtoRequest.Get(accessToken, idTipoPublicoAlvo, idCategoria);
                if (!produtoRequest.IsSuccessStatusCode)
                    return StatusCode((int)HttpStatusCode.InternalServerError);

                var produto = JsonConvert.DeserializeObject<IEnumerable<Produto>>(produtoRequest.Content.ReadAsStringAsync().Result);

                return View(produto);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
