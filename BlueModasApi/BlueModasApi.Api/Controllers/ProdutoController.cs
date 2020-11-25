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
    public class ProdutoController : BaseController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(ILogger<ProdutoController> logger, NotificationContext notification, IProdutoService produtoService) : base(logger, notification)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] int? idTipoPublicoAlvo, int? idCategoria)
        {
            try
            {
                return Ok(await _produtoService.Get(idTipoPublicoAlvo, idCategoria));
            }
            catch (Exception ex)
            {
                return Erro(ex);
            }
        }
    }
}
