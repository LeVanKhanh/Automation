using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrowserTests.Pages.Login
{
    public class PageObjectModel
    {
        [FindsBy(How = How.Id, Using = "Name")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "form input[type=submit]")]
        public IWebElement LoginButton { get; set; }
    }
}
