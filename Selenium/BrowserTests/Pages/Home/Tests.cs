using BrowserTests.Common;
using BrowserTests.Fixtures;
using BrowserTests.Helper;
using System;
using Xunit;

namespace BrowserTests.Pages.Home
{
    [Collection(Constants.FixtureCollection.WebDriverCollection)]
    public class Tests : IClassFixture<Fixture>, IDisposable
    {
        private readonly Fixture _fixture;
        public Tests(ShareCollectionFixture collectionFixture, Fixture classFixture)
        {
            // Arrange
            if(_fixture == null)
            {
                _fixture = classFixture;
                _fixture.Init(collectionFixture.ServiceProvider);
            }
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void Load()
        {
            // Arrange
            _fixture.Page.NaviageToPage();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("Home Page - Selenium", _fixture.WebDriver.Title);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void GoToPrivacyPage()
        {
            // Arrange
            _fixture.Page.NaviageToPage();
            WaitHelper.Pause();

            // Act
            // find a link by link text
            _fixture.Page.MenuComponent.GoToPrivacy();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("Privacy Policy - Selenium", _fixture.WebDriver.Title);
        }

        [Fact]
        [Trait("Category", "Smock")]
        public void GoToNetCore()
        {
            // Arrange
            _fixture.Page.NaviageToPage();
            WaitHelper.Pause();

            //Act
            _fixture.Page.GoToToNetCore();
            WaitHelper.Pause();

            //Assert
            Assert.Equal("ASP.NET documentation | Microsoft Docs", _fixture.WebDriver.Title);
        }

        public void Dispose()
        {

        }
    }

}
