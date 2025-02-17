﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiSample.Controllers
{
    [ApiController]
    //[Route("[controller]")]
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
        [Route("weatherforecast")]
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("singleforecast/{temp:int}")]
        public WeatherForecast GetForecast(int temp)
        {
            return new WeatherForecast
            {
                Date = DateTime.Now,
                Summary = Summaries.First(),
                TemperatureC = temp
            };
        }

        [HttpPost]
        [Route("singleforecastpost")]
        public WeatherForecast GetForecastPost([FromHeader] string temp)
        {
            //Request.Headers.TryGetValue("temp", out var tValue);

            return new WeatherForecast
            {
                Date = DateTime.Now,
                Summary = Summaries.First()
            };
        }


    }
}
