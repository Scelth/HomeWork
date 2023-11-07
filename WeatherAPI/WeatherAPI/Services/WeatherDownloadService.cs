using System;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class WeatherDownloadService
    {
        public async Task<Weather> SetImgPath(Weather weather)
        {

            Dictionary<string, string> weatherImages = new()
            {
                  { "rain", "rain.png" },
                  { "sun", "sun.png" },
                  { "snow", "snow.png" },
                  { "cloud", "clouds.png" },
            };

            foreach (var kvp in weatherImages)
            {
                if (weather.Description.Contains(kvp.Key))
                {
                    weather.ImgPath = kvp.Value;
                    break;
                }
            }
            return weather;
        }

        public async Task<string> GetWeatherAsync(string url)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(method: HttpMethod.Get, url);

            using var response = client.SendAsync(request).Result;
            var body = await response.Content.ReadAsStringAsync();
            return body;
        }
    }
}