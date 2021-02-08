namespace DecoratorPatternApi.Services.Notifications.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface INotifier
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Send(string message);
    }
}
