using Xunit;

namespace MyHouse.Tests.IntegrationTests.Core
{
    [CollectionDefinition(nameof(IntegrationCollection))]
    public class IntegrationCollection : ICollectionFixture<IntegrationFixture>
    {
    }
}
