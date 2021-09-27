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
        public void EmptyTest()
        {
            Console.WriteLine("HELLO WORLD TEST");
        }

        [Fact]
        public void Test1()
        {
            var value = controller.Get();
            Assert.Equal(0, value.Count());
        }
    }
}
