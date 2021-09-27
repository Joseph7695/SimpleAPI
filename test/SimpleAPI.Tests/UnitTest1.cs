using System;
using System.Linq;
using Microsoft.Extensions.Logging.Abstractions;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(NullLogger<WeatherForecastController>.Instance);
        [Fact]
        public void Test1()
        {
            var value = controller.Get();
            Assert.Equal(5, value.Count());
        }
    }
}
