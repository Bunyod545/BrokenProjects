using ProxyPatternApi.OtherLibrary;
using System;

namespace ProxyPatternApi.Logics.Proxies
{
    /// <summary>
    /// 
    /// </summary>
    public class OtherLibraryProxy : IOtherLibraryService
    {
        /// <summary>
        /// 
        /// </summary>
        private OtherLibraryService _realService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="realService"></param>
        public OtherLibraryProxy(OtherLibraryService realService)
        {
            _realService = realService;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Do work starts");
            _realService.DoWork();
            Console.WriteLine("Do work ends");
        }
    }
}
