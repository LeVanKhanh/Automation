using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BrowserTests
{
    public class HomeIndexShould : IDisposable
    {
        private readonly IWebDriver _webDriver;
        public HomeIndexShould()
        {
            // Arrange
            _webDriver = new ChromeDriver();
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void Load()
        {
            // Arrange
            _webDriver.Navigate().GoToUrl("https://localhost:44345/");

            //Assert
            Assert.Equal("Home Page - Selenium", _webDriver.Title);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void GoToPrivacyPage()
        {
            // Arrange
            _webDriver.Navigate().GoToUrl("https://localhost:44345/");
            TestHelper.Pause();
            // find a link by link text
            IWebElement link = _webDriver.FindElement(By.LinkText("Privacy"));
            link.Click();
            TestHelper.Pause();
            //Assert
            Assert.Equal("Privacy Policy - Selenium", _webDriver.Title);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void GoToNetCore()
        {
            // Arrange
            _webDriver.Navigate().GoToUrl("https://localhost:44345/");
            TestHelper.Pause();
            // find a link by relative XPath. Ref http://xpather.com/
            IWebElement link = _webDriver.FindElement(By.XPath("//a[text()[contains(.,'ASP.NET Core')]]"));
            link.Click();
            TestHelper.Pause();
            //Assert
            Assert.Equal("ASP.NET documentation | Microsoft Docs", _webDriver.Title);
        }

        public void Dispose()
        {
            _webDriver.Dispose();
        }
    }
}
