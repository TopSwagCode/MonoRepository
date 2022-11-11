using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class WeatherClient
    {
        private readonly HttpClient _httpClient;

        public WeatherClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<WeatherForecast>?> WeatherForecasts()
        {
            var response = await _httpClient.GetAsync("weatherforecast");
            return await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecast>>();
        }
    }
}
