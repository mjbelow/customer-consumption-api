using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace customer_consumption_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<DarkSky.Models.Forecast> Get(double latitude, double longitude, int year, int month, int day)
        {
          var darkSky = new DarkSky.Services.DarkSkyService("98613d2e894e074b90173af165d94d47");
          var forecast = await darkSky.GetForecast(latitude, longitude, new DarkSky.Models.OptionalParameters{ForecastDateTime = new DateTime()});

          return forecast.Response;
        }
    }
}
