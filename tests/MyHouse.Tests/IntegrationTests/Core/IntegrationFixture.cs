using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace MyHouse.Tests.IntegrationTests.Core
{
    public class IntegrationFixture : IDisposable
    {
        public IntegrationFixture()
        {
            var builder = WebHost.CreateDefaultBuilder().UseEnvironment("Test").UseStartup<TestStartup>();

            Server = new TestServer(builder);
        }

        public TestServer Server { get; }

        public void Dispose()
        {
        }
    }
}
