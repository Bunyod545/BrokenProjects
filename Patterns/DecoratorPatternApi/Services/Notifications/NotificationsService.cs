using DecoratorPatternApi.Services.Notifications.Interfaces;

namespace DecoratorPatternApi.Services.Notifications
{
    /// <summary>
    /// 
    /// </summary>
    public class NotificationsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="notifier"></param>
        public void SendWarning(INotifier notifier)
        {
            notifier.Send("Warnings on system");
        }
    }
}
