using Microsoft.AspNetCore.TestHost;

namespace MyHouse.Tests.IntegrationTests.Core
{
    public class TestBase
    {
        public TestBase(IntegrationFixture fixture)
        {
            Server = fixture.Server;
        }

        public TestServer Server { get; }
    }
}
