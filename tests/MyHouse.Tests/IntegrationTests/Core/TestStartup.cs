using Microsoft.Extensions.Configuration;
using MyHouse.API;

namespace MyHouse.Tests.IntegrationTests.Core
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}
