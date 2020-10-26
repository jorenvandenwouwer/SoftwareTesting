using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OefeningMockingOpenWeather;
using System.Reflection;

namespace OpenWeatherTest
{
    [TestClass]
    public class WeatherServiceTest
    {
        [TestMethod]
        public void GetCurrentWeatherInAntwerp_Returns_Freezing()
        {
            var openWeather = new Mock<IOpenWeatherMapApi>();
            openWeather.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(-2);
            var service = new WeatherService(openWeather.Object);
            string result = service.GetCurrentWeatherInAntwerp();
            Assert.AreEqual(result, "Brrrr, it's freezing");
        }
        [TestMethod]
        public void GetCurrentWeatherInAntwerp_Returns_Cold()
        {
            var openWeather = new Mock<IOpenWeatherMapApi>();
            openWeather.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(5);
            var service = new WeatherService(openWeather.Object);
            string result = service.GetCurrentWeatherInAntwerp();
            Assert.AreEqual(result, "It's cold");
        }
        [TestMethod]
        public void GetCurrentWeatherInAntwerp_Returns_Ok()
        {
            var openWeather = new Mock<IOpenWeatherMapApi>();
            openWeather.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(17);
            var service = new WeatherService(openWeather.Object);
            string result = service.GetCurrentWeatherInAntwerp();
            Assert.AreEqual(result, "it's ok");
        }
        [TestMethod]
        public void GetCurrentWeatherInAntwerp_Returns_Hot()
        {
            var openWeather = new Mock<IOpenWeatherMapApi>();
            openWeather.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(27);
            var service = new WeatherService(openWeather.Object);
            string result = service.GetCurrentWeatherInAntwerp();
            Assert.AreEqual(result, "It's HOT!!!");
        }
    }
}
