using System;
using Microsoft.AspNetCore.Mvc;


namespace LgParadise.WeatherApi.Controllers
{
    [ApiController]
    [Route("/api/v1/weather")]
    public class WeatherController : Controller
    {
        [HttpGet]
        [Route("timestamp")]
        public IActionResult Time([FromQuery]string name)
        {
            var now = DateTime.Now;
            return Ok(new { CurrentTimeUTC = now.ToUniversalTime(), CurrentTimeServer = now, UserProvidedName = name });
        }
    }
}
