using BrowserTests.Helper;
using BrowserTests.Pages.Login;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BrowserTests.Tests.Login
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
            _webDriver.Dispose();
        }
    }
}
