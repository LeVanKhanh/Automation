using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrowserTests.ShareComponents
{
    public abstract class Component<TComponentObjectModel> : IComponent<TComponentObjectModel>
         where TComponentObjectModel : new()
    {
        public TComponentObjectModel ComponentObjectModel { get; }
        private readonly IWebDriver _webDriver;
        public Component(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            ComponentObjectModel = new TComponentObjectModel();
            PageFactory.InitElements(webDriver, ComponentObjectModel);
        }
    }
}
