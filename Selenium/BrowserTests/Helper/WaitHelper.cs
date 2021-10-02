using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace BrowserTests.Helper
{
    public static class WaitHelper
    {
        public static void Pause(int millisecondsTimeout = 1000)
        {
            Thread.Sleep(millisecondsTimeout);
        }

        public static void WaitUntilElementClickable(IWebDriver webDriver ,By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }

        public static void WaitUntilElementClickable(IWebDriver webDriver, IWebElement webElement, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element : '" + webElement.TagName + "' was not found in current context page.");
                throw;
            }
        }
    }
}
