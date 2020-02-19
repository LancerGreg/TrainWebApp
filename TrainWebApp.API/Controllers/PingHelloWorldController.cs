using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainWebApp.API.Controllers
{
    [Produces("application/json")]
    [Route("api/ping_hello_world")]
    public class PingHelloWorldController : Controller
    {
        public PingHelloWorldController()
        {
        }

        /// <summary>
        /// The test about working 
        /// </summary>        
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(500)]
        [HttpGet("api/hello_world")]
        public async Task<IActionResult> GetHelloWorld(string helloWorld) =>
            await Task.FromResult(new OkObjectResult(helloWorld));
    }
}
