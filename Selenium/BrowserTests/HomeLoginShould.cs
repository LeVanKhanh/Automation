using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BrowserTests
{
    public class HomeLoginShould : IDisposable
    {
        private readonly IWebDriver _webDriver;
        public HomeLoginShould()
        {
            // Arrange
            _webDriver = new ChromeDriver();
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void LoginSuccess()
        {
            // Arrange
            _webDriver.Navigate().GoToUrl("https://localhost:44345/Home/Login");
            TestHelper.Pause();

            //Act
            var name = _webDriver.FindElement(By.Id("Name"));
            var password = _webDriver.FindElement(By.Id("Password"));
            name.SendKeys("name");
            password.SendKeys("password");
            var loginButton = _webDriver.FindElement(By.CssSelector("form input[type=submit]"));
            loginButton.Submit();
            TestHelper.Pause();
            //Assert
            Assert.Equal("Home Page - Selenium", _webDriver.Title);
        }

        public void Dispose()
        {
            _webDriver.Dispose();
        }
    }
}
