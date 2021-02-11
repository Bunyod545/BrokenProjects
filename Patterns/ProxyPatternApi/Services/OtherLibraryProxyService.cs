using ProxyPatternApi.OtherLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPatternApi.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class OtherLibraryProxyService : IOtherLibraryService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IOtherLibraryService service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public OtherLibraryProxyService(IOtherLibraryService service)
        {
            this.service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Do work starts");
            service.DoWork();
            Console.WriteLine("Do work ends");
        }
    }
}
