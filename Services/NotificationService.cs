using dotnet_notification.Interfaces;
using dotnet_notification.Models;

namespace dotnet_notification.Services
{
    public class NotificationService : INotification
    {
        private List<Notification> _notifications;
        public NotificationService()
        {
            _notifications = new List<Notification>();
        }

        public void Handle(Notification model) => _notifications.Add(model);
        public List<Notification> GetNotifications() => _notifications;
        public bool HasNotification() => _notifications.Any();
        public void Clear() => _notifications.Clear();
    }
}