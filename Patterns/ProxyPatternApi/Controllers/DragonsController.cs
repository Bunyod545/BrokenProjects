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
        private readonly IOtherLibraryService Service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public DragonsController(IOtherLibraryService service)
        {
            Service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyDragon()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryDragon()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkDragon()
        {
            Service.DoWork();
        }
    }
}