using MyHouse.API;

namespace MyHouse.Tests.IntegrationTests.Core;

public class TestStartup : Startup
{
    public TestStartup(IConfiguration configuration)
        : base(configuration)
    {
    }
}
