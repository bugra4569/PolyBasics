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
    public class TroubledProducerController : ControllerBase
    {
        private static int problemCount = 0;
        [HttpGet("GetSomeValue")]
        public IActionResult GetSomeValue()
        {
            problemCount++;
            if (problemCount % 2 == 0)
                return Ok();
            return BadRequest("You deserve better than me");
        }
    }
}
