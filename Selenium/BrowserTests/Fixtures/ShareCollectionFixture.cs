using BrowserTests.Common;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BrowserTests.Fixtures
{
    [CollectionDefinition(Constants.FixtureCollection.WebDriverCollection)]
    public class ShareCollectionFixture : CollectionFixture<ShareCollectionFixture>, IDisposable
    {
        public IServiceProvider ServiceProvider;
        public ShareCollectionFixture() : base(new ServiceCollection())
        {
            Services.AddSingleton<IWebDriver, ChromeDriver>();
            Services.AddScoped<Pages.Home.Page>();
            Services.AddScoped<Pages.Login.Page>();
            Services.AddScoped<Pages.Privacy.Page>();

            ServiceProvider = Services.BuildServiceProvider();
        }

        public void Dispose()
        {
            IWebDriver webDriver = ServiceProvider.GetService<IWebDriver>();
            if (webDriver != null)
            {
                webDriver.Quit();
                webDriver.Dispose();
            }
        }
    }
}
