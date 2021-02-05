using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Consumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        private readonly IHttpClientFactory _client;
        public IntegrationController(IHttpClientFactory client)
        {
            _client = client;
        }
        [HttpGet("ImpatientClientGetSlowValue")]
        public async Task<IActionResult> ImpatientClientGetSlowValue()
        {

            var url = $"http://localhost:63441/api/SlowProcuder/GetSomeValue";

            var client = _client.CreateClient("ImpatientClient");
            var response = await client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            
            return Ok(result);
        }
        [HttpGet("PatientClientGetSlowValue")]
        public async Task<IActionResult> PatientClientGetSlowValue()
        {

            var url = $"http://localhost:63441/api/SlowProcuder/GetSomeValue";

            var client = _client.CreateClient("PatientClient");
            var response = await client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            return Ok(result);
        }

        [HttpGet("ContinuousClientGetTroubledValue")]
        public async Task<IActionResult> ContinuousClientGetTroubledValue()
        {

            var url = $"http://localhost:63441/api/TroubledProducer/GetSomeValue";

            var client = _client.CreateClient("ContinuousClient");
            var response = await client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            return Ok(result);
        }

    }
}
