using DecoratorPatternApi.Services.Notifications.Interfaces;
using System;

namespace DecoratorPatternApi.Services.Notifications.Notifiers
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailNotifier : INotifier
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Console.WriteLine("Send notifier to Email");
        }
    }
}
