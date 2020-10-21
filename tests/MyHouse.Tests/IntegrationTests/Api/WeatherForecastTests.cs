using MyHouse.Tests.IntegrationTests.Core;
using Xunit;

namespace MyHouse.Tests.IntegrationTests.Api
{
    [Collection(nameof(IntegrationCollection))]
    public class WeatherForecastTests : TestBase
    {
        public WeatherForecastTests(IntegrationFixture fixture)
            : base(fixture)
        {
        }

        [Fact]
        public void Test1()
        {
            Assert.True(false);
        }
    }
}
