using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;
using System;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DragonsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private OtherLibraryService _otherLibraryService;

        /// <summary>
        /// 
        /// </summary>
        public DragonsController()
        {
            _otherLibraryService = new OtherLibraryService();
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyDragon()
        {
            Console.WriteLine("Do work starts");
            _otherLibraryService.DoWork();
            Console.WriteLine("Do work ends");
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryDragon()
        {
            Console.WriteLine("Do work starts");
            _otherLibraryService.DoWork();
            Console.WriteLine("Do work ends");
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkDragon()
        {
            Console.WriteLine("Do work starts");
            _otherLibraryService.DoWork();
            Console.WriteLine("Do work ends");
        }
    }
}