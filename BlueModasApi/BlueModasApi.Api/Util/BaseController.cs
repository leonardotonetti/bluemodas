using System;
using BlueModasApi.Business.Util.Notification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlueModasApi.Api.Util
{
    public class BaseController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly NotificationContext _notification;

        public BaseController(ILogger logger, NotificationContext notification)
        {
            _logger = logger;
            _notification = notification;
        }

        public StatusCodeResult Error(Exception ex)
        {
            _logger.LogError("Ocorreu um erro interno. Erro: {0}. Onde: {1}", ex.Message, ex.StackTrace);
            _notification.AddInternalError();
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
