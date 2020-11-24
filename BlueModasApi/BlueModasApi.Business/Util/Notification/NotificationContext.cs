using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace BlueModasApi.Business.Util.Notification
{
    public class NotificationContext
    {
        private readonly List<Notification> _notifications;
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public bool HasNotifications => _notifications.Any();
        public HttpStatusCode StatusCode { get; set; }

        public NotificationContext()
        {
            _notifications = new List<Notification>();
        }

        public void AddInternalError()
        {
            _notifications.Add(new Notification("ErroInterno", "Ocorreu um erro interno inesperado no servidor."));
            StatusCode = HttpStatusCode.InternalServerError;
        }

        public void AddNotification(string key, string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            _notifications.Add(new Notification(key, message));
            StatusCode = statusCode;
        }

        public void AddNotification(Notification notification, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            _notifications.Add(notification);
            StatusCode = statusCode;
        }
    }
}
