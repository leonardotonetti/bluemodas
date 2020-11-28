using BlueModasWeb.UI.Web.ViewModel.Carrinho;
using Microsoft.AspNetCore.Mvc;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class FinalizarController : Controller
    {
        public IActionResult Finalizar(CarrinhoViewModel carrinho)
        {
            return View(carrinho);
        }
    }
}
