using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GnomesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IOtherLibraryService Service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public GnomesController(IOtherLibraryService service)
        {
            Service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyGnomes()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryGnomes()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkGnomes()
        {
            Service.DoWork();
        }
    }
}