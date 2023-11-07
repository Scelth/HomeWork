using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using WeatherAPI.Models;
using WeatherAPI.Services;

namespace WeatherAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Weather Weather { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async void OnPost()
        {
            WeatherDownloadService weatherService = new();
            var city = Request.Form["cityName"];
            var url = $"https://goweather.herokuapp.com/weather/{city}";
            var weatherData = weatherService.GetWeatherAsync(url);

            Weather = JsonSerializer.Deserialize<Weather>(weatherData.Result);
            Weather = await weatherService.SetImgPath(Weather);

        }
    }
}