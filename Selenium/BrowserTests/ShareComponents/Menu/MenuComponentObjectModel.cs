using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrowserTests.Pages.ShareComponents.Menu
{
    public class MenuComponentObjectModel
    {
        [FindsBy(How = How.XPath, Using = "/html/body/header/nav/div/div/ul/li[1]/a")]
        public IWebElement MenuLinkHome { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/header/nav/div/div/ul/li[2]/a")]
        public IWebElement MenuLinkPrivacy { get; set; }
    }
}
