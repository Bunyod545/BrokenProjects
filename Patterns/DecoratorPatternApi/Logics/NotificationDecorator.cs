using DecoratorPatternApi.Services.Notifications;
using DecoratorPatternApi.Services.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPatternApi.Logic
{
    public abstract class NotificationDecorator : NotificationsService
    {
        private readonly INotificationsService _notification;
        private INotificationsService service;

        public NotificationDecorator(INotificationsService notification) {
            _notification = notification;
        }        

        public override void SendWarning(INotifier notifier) {
            if (_notification != null)
            {
                _notification.SendWarning(notifier);
            }
            else
            {
                _notification.SendWarning(null) ;
            }
        }
    }
}
