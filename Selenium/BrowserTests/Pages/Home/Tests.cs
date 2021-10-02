using BrowserTests.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BrowserTests.Pages.Home
{
    public class Tests : IDisposable
    {
        private readonly IWebDriver _webDriver;
        private readonly Page _page;
        public Tests()
        {
            // Arrange
            _webDriver = new ChromeDriver();
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
            _webDriver.Dispose();
        }
    }

}
