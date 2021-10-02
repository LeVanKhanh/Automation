using BrowserTests.Common.Pages;
using OpenQA.Selenium;

namespace BrowserTests.Pages.Privacy
{
    public class Page : PageObject<PageObjectModel>
    {
        public Page(IWebDriver webDriver)
            : base(webDriver, "https://localhost:44345/", "Home Page - Selenium")
        {

        }
    }
}
