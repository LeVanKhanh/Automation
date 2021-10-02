using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BrowserTests.Fixtures
{
    public abstract class CollectionFixture<TFixture> : ICollectionFixture<TFixture>
        where TFixture : class
    {
        protected IServiceCollection Services;
        protected CollectionFixture(IServiceCollection services)
        {
            Services = services;
        }
    }
}
