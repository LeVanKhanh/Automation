using BrowserTests.Common.Pages;
using OpenQA.Selenium;

namespace BrowserTests.Pages.Login
{
    public class Page : PageObject<PageObjectModel>
    {
        public Page(IWebDriver webDriver)
            : base(webDriver, "https://localhost:44345/Home/Login", "Login - Selenium")
        {

        }

        public void EnterAccount(string usename, string password)
        {
            PageObjectModel.Username.SendKeys(usename);
            PageObjectModel.Password.SendKeys(password);
        }

        public void Submit()
        {
            PageObjectModel.LoginButton.Submit();
        }
    }
}
