using BrowserTests.Common;
using BrowserTests.Fixtures;
using BrowserTests.Helper;
using OpenQA.Selenium;
using System;
using Xunit;

namespace BrowserTests.Pages.Home
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
        public void Load()
        {
            // Arrange
            _page.NaviageToPage();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("Home Page - Selenium", _webDriver.Title);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void GoToPrivacyPage()
        {
            // Arrange
            _page.NaviageToPage();
            WaitHelper.Pause();

            // Act
            // find a link by link text
            _page.MenuComponent.GoToPrivacy();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("Privacy Policy - Selenium", _webDriver.Title);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void GoToNetCore()
        {
            // Arrange
            _page.NaviageToPage();
            WaitHelper.Pause();

            //Act
            _page.GoToToNetCore();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("ASP.NET documentation | Microsoft Docs", _webDriver.Title);
        }

        public void Dispose()
        {

        }
    }

}
