using Microsoft.AspNetCore.Mvc;
using RainfallOpenApi.Model;
using System;
using System.Net;
using System.Text.Json;

namespace RainfallOpenApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainfallController : ControllerBase
    {
        private readonly ILogger<RainfallController> _logger;

        public RainfallController(ILogger<RainfallController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetRainfallList")]
        public async Task<ActionResult<Root>> GetRainfallListAsync()
        {
            try
            {
                string url = @"https://environment.data.gov.uk/flood-monitoring/id/floods";
                using (var httpClient = new HttpClient())
                {
                    string json = await httpClient.GetStringAsync(url);
                    var obj = JsonSerializer.Deserialize<Root>(json);
                    return obj ?? new Root();
                }
            }
            catch 
            { 
                return new Root();
            }
        }
    }
}
