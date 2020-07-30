using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Transactions;
using ExampleApi.Service.Services.Entities;
using ExampleApi.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ExampleApi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWeatherApiService _weatherApiService;


        public IndexModel(IWeatherApiService weatherApiService)
        {
            _weatherApiService = weatherApiService;
        }

        public async Task OnGet()
        {
           await _weatherApiService.WeatherData();
        }

        public void OnPost()
        {

        }
    }
}
