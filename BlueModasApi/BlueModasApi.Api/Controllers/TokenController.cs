using System;
using BlueModasApi.Api.Util;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Util.Notification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlueModasApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : BaseController
    {
        private readonly ITokenService _tokenService;

        public TokenController(ILogger<TokenController> logger, NotificationContext notification, ITokenService tokenService) : base(logger, notification)
        {
            _tokenService = tokenService;
        }

        [HttpGet]
        public ActionResult GenerateToken()
        {
            try
            {
                var token = _tokenService.GenerateToken();
                return Ok(new
                {
                    AccessToken = token
                });
            }
            catch (Exception ex)
            {
                return Erro(ex);
            }
        }

    }
}
