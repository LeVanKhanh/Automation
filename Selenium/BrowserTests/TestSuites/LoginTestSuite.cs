using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BrowserTests.TestSuites
{
    [Binding]
    public class LoginTestSuite : IDisposable
    {
        private readonly IWebDriver _webDriver;
        public LoginTestSuite()
        {
            _webDriver = new ChromeDriver();
        }

        [Given(@"I am logged in as Guest")]
        public void GivenAccessLoginPage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44345/Home/Login");
            TestHelper.Pause();
        }

        [Given(@"I input the correct account")]
        public void GivenTheNameIsNotEmpty()
        {
            var name = _webDriver.FindElement(By.Id("Name"));
            name.SendKeys("guest");

            var password = _webDriver.FindElement(By.Id("Password"));
            password.SendKeys("guest");
        }

        [When(@"I click on login")]
        public void WhenIInputCorrectNameAndPassword()
        {
            var loginButton = _webDriver.FindElement(By.CssSelector("form input[type=submit]"));
            loginButton.Submit();
            TestHelper.Pause();
        }

        [Then(@"I can access home page")]
        public void ThenICanAccessHomePage()
        {
            Assert.Equal("Home Page - Selenium", _webDriver.Title);
        }

        [Given(@"I input the incorrect account")]
        public void GivenIInputTheIncorrectAccount()
        {
            var name = _webDriver.FindElement(By.Id("Name"));
            name.SendKeys("name");

            var password = _webDriver.FindElement(By.Id("Password"));
            password.SendKeys("password");
        }

        [Then(@"I go to error page")]
        public void ThenIGoToErrorPage()
        {
            Assert.Equal("Error - Selenium", _webDriver.Title);
        }

        public void Dispose()
        {
            _webDriver.Quit();
            _webDriver.Dispose();
        }
    }
}
