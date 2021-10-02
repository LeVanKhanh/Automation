using BrowserTests.Common;
using BrowserTests.Fixtures;
using BrowserTests.Helper;
using BrowserTests.Pages.Login;
using OpenQA.Selenium;
using System;
using Xunit;

namespace BrowserTests.Tests.Login
{
    [Collection(Constants.FixtureCollection.WebDriverCollection)]
    public class Tests : IDisposable
    {
        private readonly IWebDriver _webDriver;
        private readonly Page _page;
        public Tests(WebDriverCollectionFixture fixture)
        {
            // Arrange
            _webDriver = fixture.WebDriver;
            _page = new Page(_webDriver);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void LoginSuccess()
        {
            // Arrange
            _page.NaviageToPage();
            _page.EnsurePageLoaded(_page.PageObjectModel.LoginButton);

            //Act
            _page.EnterAccount("guest", "guest");
            _page.Submit();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("Home Page - Selenium", _webDriver.Title);
        }

        public void Dispose()
        {

        }
    }
}
