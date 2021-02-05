using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Procuder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlowProcuderController : ControllerBase
    {
        [HttpGet("GetSomeValue")]
        public IActionResult GetSomeValue()
        {
            Task.Delay(20000).Wait();
            return Ok("Some not important information.");
        }
    }
}
