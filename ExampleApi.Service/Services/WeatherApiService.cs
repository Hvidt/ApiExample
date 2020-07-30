using ExampleApi.Service.Services.Entities;
using ExampleApi.Service.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExampleApi.Service.Services
{
    public class WeatherApiService : IWeatherApiService
    {

        public async Task WeatherData()
        {
            //Create Client
            using HttpClient client = new HttpClient();
            // Using client to make call (Get data)
            var respone = await client.GetAsync("https://www.metaweather.com/api/location/554890/");
            //Throws exception if anything went wrong
            respone.EnsureSuccessStatusCode();

            string content = await respone.Content.ReadAsStringAsync();
            var forecast = JsonConvert.DeserializeObject<WeatherForecast>(content);

        }
    }
}
