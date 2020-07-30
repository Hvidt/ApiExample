using ExampleApi.Service.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ExampleApi.Service.Services.Entities.WeatherForecast;

namespace ExampleApi.Service.Services.Interfaces
{
    public interface IWeatherApiService
    {
         Task WeatherData();
    }
}
