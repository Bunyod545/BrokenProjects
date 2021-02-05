using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ZombiesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private OtherLibraryService _otherLibraryService;

        /// <summary>
        /// 
        /// </summary>
        public ZombiesController()
        {
            _otherLibraryService = new OtherLibraryService();
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyZombies()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryZombies()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkZombies()
        {
            _otherLibraryService.DoWork();
        }
    }
}