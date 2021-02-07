using ProxyPatternApi.OtherLibrary;
using System;

namespace ProxyPatternApi.Logics.Proxies
{
    /// <summary>
    /// 
    /// </summary>
    public class OtherLibraryProxyService : IOtherLibraryService
    {
        /// <summary>
        /// 
        /// </summary>
        private IOtherLibraryService _realService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="realService"></param>
        public OtherLibraryProxyService()
        {
            _realService = new OtherLibraryService();
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
