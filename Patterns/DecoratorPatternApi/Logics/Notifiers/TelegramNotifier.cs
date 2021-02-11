using DecoratorPatternApi.Logic;
using DecoratorPatternApi.Services.Notifications.Interfaces;
using System;

namespace DecoratorPatternApi.Services.Notifications.Notifiers
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramNotifier : NotificationDecorator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public TelegramNotifier(INotificationsService service) : base(service)
        {
        }

        public override void SendWarning(INotifier notifier)
        {
            base.SendWarning(notifier);
        }
    }
}
