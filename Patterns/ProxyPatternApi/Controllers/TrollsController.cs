using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TrollsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private OtherLibraryService _otherLibraryService;

        /// <summary>
        /// 
        /// </summary>
        public TrollsController()
        {
            _otherLibraryService = new OtherLibraryService();
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyTrolls()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryTrolls()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkTrolls()
        {
            _otherLibraryService.DoWork();
        }
    }
}