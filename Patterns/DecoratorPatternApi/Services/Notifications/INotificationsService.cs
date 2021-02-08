using DecoratorPatternApi.Services.Notifications.Interfaces;

namespace DecoratorPatternApi.Services.Notifications
{
    /// <summary>
    /// 
    /// </summary>
    public interface INotificationsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="notifier"></param>
        void SendWarning(INotifier notifier);
    }
}
