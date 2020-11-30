using System;
using System.Threading.Tasks;
using BlueModasApi.Api.Util;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Util.Notification;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlueModasApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : BaseController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(ILogger<ProdutoController> logger, NotificationContext notification, IClienteService clienteService) : base(logger, notification)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string nome, string sobreNome)
        {
            try
            {
                return Ok(await _clienteService.Get(nome, sobreNome));
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}
