using dotnet_notification.Interfaces;
using dotnet_notification.Models;

namespace dotnet_notification.Services
{
    public abstract class BaseServices
    {
        private readonly INotification _notification;

        public BaseServices(INotification notification)
        {
            _notification = notification;
        }
        protected void Notify(string message)
        {
            _notification.Handle(new Notification(message));
        }
    }
}