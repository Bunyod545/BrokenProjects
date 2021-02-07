using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.Logics.Proxies;
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
        private IOtherLibraryService _otherLibraryService;

        /// <summary>
        /// 
        /// </summary>
        public DragonsController()
        {
            _otherLibraryService = new OtherLibraryProxy(new OtherLibraryService());
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyDragon()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryDragon()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkDragon()
        {
            _otherLibraryService.DoWork();
        }
    }
}