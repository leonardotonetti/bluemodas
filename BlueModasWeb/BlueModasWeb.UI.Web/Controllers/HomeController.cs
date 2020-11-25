using Microsoft.AspNetCore.Mvc;

namespace BlueModasWeb.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
