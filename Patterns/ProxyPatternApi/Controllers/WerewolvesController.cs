using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WerewolvesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IOtherLibraryService Service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public WerewolvesController(IOtherLibraryService service)
        {
            Service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyWerewolves()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryWerewolves()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkWerewolves()
        {
            Service.DoWork();
        }
    }
}