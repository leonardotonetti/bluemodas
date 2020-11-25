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
    public class CategoriaController : BaseController
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ILogger<CategoriaController> logger, NotificationContext notification, ICategoriaService categoriaService) : base(logger, notification)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await _categoriaService.Get());
            }
            catch (Exception ex)
            {
                return Erro(ex);
            }
        }
    }
}
