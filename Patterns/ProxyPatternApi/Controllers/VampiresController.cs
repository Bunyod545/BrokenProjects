using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VampiresController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private OtherLibraryService _otherLibraryService;

        /// <summary>
        /// 
        /// </summary>
        public VampiresController()
        {
            _otherLibraryService = new OtherLibraryService();
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyVampires()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryVampires()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkVampires()
        {
            _otherLibraryService.DoWork();
        }
    }
}