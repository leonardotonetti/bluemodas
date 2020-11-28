using System.Threading.Tasks;
using BlueModasApi.Business.Util.Notification;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BlueModasApi.Api.Util.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        private readonly NotificationContext _notificationContext;

        public ValidationFilter(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                foreach (var item in context.ModelState)
                    foreach (var erros in item.Value.Errors)
                        _notificationContext.AddNotification(item.Key, erros.ErrorMessage);
                return;
            }

            await next();
        }
    }
}
