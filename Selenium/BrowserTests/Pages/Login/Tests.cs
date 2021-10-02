using BrowserTests.Common;
using BrowserTests.Fixtures;
using BrowserTests.Helper;
using BrowserTests.Pages.Login;
using System;
using Xunit;

namespace BrowserTests.Tests.Login
{
    [Collection(Constants.FixtureCollection.WebDriverCollection)]
    public class Tests : IClassFixture<Fixture>, IDisposable
    {
        private readonly Fixture _fixture;
        public Tests(ShareCollectionFixture collectionFixture, Fixture classFixture)
        {
            // Arrange
            if (_fixture == null)
            {
                _fixture = classFixture;
                _fixture.Init(collectionFixture.ServiceProvider);
            }
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void LoginSuccess()
        {
            // Arrange
            _fixture.Page.NaviageToPage();
            _fixture.Page.EnsurePageLoaded(_fixture.Page.PageObjectModel.LoginButton);

            //Act
            _fixture.Page.EnterAccount("guest", "guest");
            _fixture.Page.Submit();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("Home Page - Selenium", _fixture.WebDriver.Title);
        }

        public void Dispose()
        {

        }
    }
}
