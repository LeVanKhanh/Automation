using BrowserTests.Pages.ShareComponents.Menu;
using BrowserTests.ShareComponents;
using OpenQA.Selenium;

namespace BrowserTests.PageShareComponents
{
    public class MenuComponent : Component<MenuComponentObjectModel>
    {
        public MenuComponent(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void GoToPrivacy()
        {
            ComponentObjectModel.MenuLinkPrivacy.Click();
        }

        public void GoToHome()
        {
            ComponentObjectModel.MenuLinkHome.Click();
        }
    }
}
