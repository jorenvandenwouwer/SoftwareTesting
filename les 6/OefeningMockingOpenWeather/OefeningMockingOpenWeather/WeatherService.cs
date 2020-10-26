using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingOpenWeather
{
    public class WeatherService
    {
        private readonly IOpenWeatherMapApi _api;

        public WeatherService(IOpenWeatherMapApi api)
        {
            _api = api;
        }

        public string GetCurrentWeatherInAntwerp()
        {
            var temp = _api.GetCurrentTemperatureInAntwerp();
            if (temp < 0)
            {
                return "Brrrr, it's freezing";
            }
            if (temp < 15)
            {
                return "It's cold";
            }
            if (temp < 24)
            {
                return "it's ok";
            }
            return "It's HOT!!!";
        }
    }
}
