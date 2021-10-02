using BrowserTests.Common.Pages;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using System;

namespace BrowserTests.Fixtures
{
    public class ClassFixture<TPage> : IDisposable
        where TPage : IPageObject
    {
        private IServiceProvider _serviceProvider;
        private TPage _page;
        private IWebDriver _webDriver;

        public TPage Page
        {
            get
            {
                if (_page == null)
                {
                    _page = _serviceProvider.GetService<TPage>();
                }
                return _page;
            }
        }
        public virtual IWebDriver WebDriver
        {
            get
            {
                if (_webDriver == null)
                {
                    _webDriver = _serviceProvider.GetService<IWebDriver>();
                }
                return _webDriver;
            }
        }

        public virtual void Init(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Dispose()
        {

        }
    }
}
