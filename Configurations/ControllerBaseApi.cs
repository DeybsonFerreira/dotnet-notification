using dotnet_notification.Interfaces;
using dotnet_notification.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_notification.Configurations
{
    public abstract class ControllerBaseApi : ControllerBase
    {
        private readonly INotification _notification;

        public ControllerBaseApi(INotification notification)
        {
            _notification = notification;
        }

        protected IActionResult SendResponse(IActionResult actionResult)
        {
            if (!_notification.HasNotification())
                return actionResult;

            return BadRequest(new
            {
                success = false,
                errors = _notification.GetNotifications().Select(x => x.Message)
            });
        }
    }
}