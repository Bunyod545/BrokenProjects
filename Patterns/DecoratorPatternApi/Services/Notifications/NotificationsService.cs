using DecoratorPatternApi.Services.Notifications.Interfaces;

namespace DecoratorPatternApi.Services.Notifications
{
    /// <summary>
    /// 
    /// </summary>
    public class NotificationsService :INotificationsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="notifier"></param>
        public virtual void SendWarning(INotifier notifier)
        {
            notifier.Send("Warnings on system");
        }
    }
}
