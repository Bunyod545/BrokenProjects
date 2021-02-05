using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GiantsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private OtherLibraryService _otherLibraryService;

        /// <summary>
        /// 
        /// </summary>
        public GiantsController()
        {
            _otherLibraryService = new OtherLibraryService();
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyGiants()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryGiants()
        {
            _otherLibraryService.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkGiants()
        {
            _otherLibraryService.DoWork();
        }
    }
}