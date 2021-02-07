using Microsoft.AspNetCore.Mvc;
using ProxyPatternApi.OtherLibrary;

namespace ProxyPatternApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrksController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IOtherLibraryService Service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public OrksController(IOtherLibraryService service)
        {
            Service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public void BeHappyOrks()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontCryOrks()
        {
            Service.DoWork();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DontSleepAtWorkOrks()
        {
            Service.DoWork();
        }
    }
}