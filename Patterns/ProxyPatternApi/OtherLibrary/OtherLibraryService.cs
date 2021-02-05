using System;

namespace ProxyPatternApi.OtherLibrary
{
    /// <summary>
    /// Other library interface don't change this file
    /// </summary>
    public class OtherLibraryService : IOtherLibraryService
    {
        /// <summary>
        /// Other library method don't change it
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Payment successfully");
        }
    }
}
