using Microsoft.AspNetCore.Mvc;
using SimpleService;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ISimpleService _simpleService;

        /// <summary>
        /// ApplicationController
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="portalService"></param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ISimpleService simpleService)
        {
            _logger = logger;
            _simpleService = simpleService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecast = _simpleService.GetForecast();
            _logger.LogInformation("Forcast returned {@forecast}", forecast);
            return _simpleService.GetForecast();           
        }
    }
}
