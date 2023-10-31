using dotnet_notification.Models;

namespace dotnet_notification.Interfaces
{
    public interface INotification
    {
        void Handle(Notification model);
        List<Notification> GetNotifications();
        bool HasNotification();
        void Clear();
    }
}