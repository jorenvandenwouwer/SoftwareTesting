using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingOpenWeather
{
    public interface IOpenWeatherMapApi
    {
        public float GetCurrentTemperatureInAntwerp();
    }
}
