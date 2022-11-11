using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedModels;

namespace WebApp.Pages
{
    public class WeatherModel : PageModel
    {
        private readonly ILogger<WeatherModel> _logger;
        private readonly WeatherClient _weatherClient;

        public WeatherModel(ILogger<WeatherModel> logger, WeatherClient weatherClient)
        {
            _logger = logger;
            _weatherClient = weatherClient;
        }

        public IEnumerable<WeatherForecast>? WeatherForecasts { get; set; }

        public async Task OnGet()
        {
            WeatherForecasts = await _weatherClient.WeatherForecasts();
        }
    }
}