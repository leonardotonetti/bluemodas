using System;
using System.Threading.Tasks;
using BlueModasApi.Api.Util;
using BlueModasApi.Business.Dto;
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
    public class PedidoController : BaseController
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(ILogger<PedidoController> logger, NotificationContext notification, IPedidoService pedidoService) : base(logger, notification)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PedidoDto pedido)
        {
            try
            {
                return Ok(await _pedidoService.Post(pedido));
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}
