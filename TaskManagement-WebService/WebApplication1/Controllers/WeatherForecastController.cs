using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("day/{dayName}")]
        public IActionResult GetWeatherForecastByDay(string dayName) 
        {
            var temperature = Random.Shared.Next(-20, 55);
            return Ok(temperature);
        }

        [HttpPost("add-forecast")]
        public IActionResult AddWeatherForecastData([FromBody] AddWeatherDataRequest data ) 
        {
            return Ok( new WeatherDataResponse { Day = data.Day, Temp = data.Temp});
        }

        [HttpPut("update-forecast/{dayName}/{temp}")]
        public IActionResult UpdateWeatherForecastData(string day, string temp)
        {
            return Ok($"Updated temp for {day} to {temp}");
        }
    }
}
