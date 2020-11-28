﻿using BlueModasWeb.UI.Web.ViewModel.Carrinho;
using Microsoft.AspNetCore.Mvc;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class CarrinhoController : Controller
    {
        [HttpPost]
        public IActionResult Carrinho(CarrinhoViewModel carrinho)
        {
            return View(carrinho);
        }
    }
}
