using DecoratorPatternApi.Services.Notifications;
using DecoratorPatternApi.Services.Notifications.Interfaces;
using DecoratorPatternApi.Services.Notifications.Notifiers;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private INotificationsService _notificationsService;
        private INotifier _notifer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="notificationsService"></param>
        public NotificationsController(INotificationsService notificationsService)
        {
            _notificationsService = notificationsService;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SendTelegramWarning()
        {

            var telegramNotifier = new TelegramNotifier(_notificationsService);
            _notificationsService.SendWarning(_notifer);
        }

        /// <summary>
        /// 
        /// </summary>
        public void SendSmsWarning()
        {
            var smsNotifier = new SmsNotifier(_notificationsService);
            _notificationsService.SendWarning(_notifer);
        }

        /// <summary>
        /// 
        /// </summary>
        public void SendEmailWarning()
        {
            var emailNotifier = new EmailNotifier(_notificationsService);
            _notificationsService.SendWarning(_notifer);
        }
    }
}
