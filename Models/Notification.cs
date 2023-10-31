using dotnet_notification.Interfaces;

namespace dotnet_notification.Models
{
    public class Notification
    {
        public string Message;

        public Notification(string message)
        {
            Message = message;
        }
    }
}