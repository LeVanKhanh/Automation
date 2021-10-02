using BrowserTests.Common.Pages;
using BrowserTests.PageShareComponents;
using OpenQA.Selenium;

namespace BrowserTests.Pages.Home
{
    public class Page : PageObject<PageObjectModel>
    {
        private MenuComponent _menuComponent;
        public MenuComponent MenuComponent
        {
            get
            {
                if (_menuComponent == null)
                {
                    _menuComponent = new MenuComponent(_webDriver);
                }
                return _menuComponent;
            }
        }
        public Page(IWebDriver webDriver)
            : base(webDriver, "https://localhost:44345/", "Home Page - Selenium")
        {

        }

        public void GoToToNetCore()
        {
            PageObjectModel.LinkToNetCore.Click();
        }
    }
}
