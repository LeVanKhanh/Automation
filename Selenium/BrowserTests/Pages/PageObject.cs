using BrowserTests.Helper;
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;

namespace BrowserTests.Common.Pages
{
    public abstract class PageObject<TPageObjectModel> : IPageObject<TPageObjectModel>
         where TPageObjectModel : new()
    {
        public TPageObjectModel PageObjectModel { get; }
        public string PageTitle { get; }
        public Uri Uri { get; set; }
        protected readonly IWebDriver _webDriver;
        public PageObject(IWebDriver webDriver, string url, string tile = "")
        {
            PageTitle = tile;
            Uri = new Uri(url);
            _webDriver = webDriver;
            PageObjectModel = new TPageObjectModel();
            PageFactory.InitElements(webDriver, PageObjectModel);
        }

        public void NaviageToPage()
        {
            _webDriver.Navigate().GoToUrl(Uri.AbsoluteUri);
        }

        public void EnsurePageLoaded(By elementLocator, int timeout = 10)
        {
            WaitHelper.WaitUntilElementClickable(_webDriver, elementLocator, timeout);
        }

        public void EnsurePageLoaded(IWebElement webElement, int timeout = 10)
        {
            WaitHelper.WaitUntilElementClickable(_webDriver, webElement, timeout);
        }
    }
}
