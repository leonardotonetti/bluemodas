using System;
using Microsoft.AspNetCore.Mvc;

namespace BlueModasApi.Api.Controllers
{
    [Route("")]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public ActionResult Ping()
        {
            return Ok($"Tudo está funcionando por aqui.......... Data: {DateTime.Now}");
        }
    }
}
