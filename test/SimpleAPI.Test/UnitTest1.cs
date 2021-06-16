using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController(null);
        
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Deneme();

            Assert.Equal("Bunyamin KILINC",returnValue.Value);
        }



    }
}
