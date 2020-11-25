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
    public class TipoPublicoAlvoController : BaseController
    {
        private readonly ITipoPublicoAlvoService _tipoPublicoAlvoService;

        public TipoPublicoAlvoController(ILogger<TipoPublicoAlvoController> logger, NotificationContext notification, ITipoPublicoAlvoService tipoPublicoAlvoService) : base(logger, notification)
        {
            _tipoPublicoAlvoService = tipoPublicoAlvoService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await _tipoPublicoAlvoService.Get());
            }
            catch (Exception ex)
            {
                return Erro(ex);
            }
        }
    }
}
