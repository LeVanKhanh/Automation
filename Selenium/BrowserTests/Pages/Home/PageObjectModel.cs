using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrowserTests.Pages.Home
{
    public class PageObjectModel
    {
        // find a link by relative XPath. Ref http://xpather.com/
        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'ASP.NET Core')]]")]
        public IWebElement LinkToNetCore { get; set; }
    }
}
