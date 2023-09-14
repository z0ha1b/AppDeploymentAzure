using Simple.API.Controllers;

namespace Simple.API.Tests;

public class UnitTest1
{
    [Fact]
    public void GetTemperatures()
    {
        var controller = new WeatherForecastController();
        var result = controller.Get();

        Assert.NotNull(result);
    }
}