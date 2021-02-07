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
        private readonly IOtherLibraryService Service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public VampiresController(IOtherLibraryService service)
        {
            Service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyVampires()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryVampires()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkVampires()
        {
            Service.DoWork();
        }
    }
}