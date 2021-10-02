using BrowserTests.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BrowserTests.Fixtures
{
    public class WebDriverCollectionFixture : IDisposable
    {
        public IWebDriver WebDriver { get; }
        public WebDriverCollectionFixture()
        {
            WebDriver = new ChromeDriver();
        }

        public void Dispose()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }

    [CollectionDefinition(Constants.FixtureCollection.WebDriverCollection)]
    public class WebDriverCollection : ICollectionFixture<WebDriverCollectionFixture>
    {

    }
}
