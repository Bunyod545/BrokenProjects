using DecoratorPatternApi.Logic;
using DecoratorPatternApi.Services.Notifications.Interfaces;
using System;

namespace DecoratorPatternApi.Services.Notifications.Notifiers
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailNotifier : NotificationDecorator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public EmailNotifier(INotificationsService service) : base(service)
        {
        }

        public override void SendWarning(INotifier notifier)
        {
            base.SendWarning(notifier);
        }
    }
}
