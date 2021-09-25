using Authentication;
using TechTalk.SpecFlow;
using Xunit;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageBackgroundSteps
    {
        private AuthenticationProvider _authenticationProvider { get; set; }

        [Given(@"I access the authentication page")]
        public void IAccessTheAuthenticationPage()
        {
            _authenticationProvider = new AuthenticationProvider();
        }

        [Given(@"Background the username is (.*)")]
        public void GivenBackgroundTheUsernameIs_PO(string username)
        {
            _authenticationProvider.Username = username;
        }

        [Given(@"Background the password is (.*)")]
        public void GivenBackgroundThePasswordIs_PO(string password)
        {
            _authenticationProvider.Password = password;
        }

        [When(@"Background trigger login")]
        public void WhenBackgroundTriggerLogin()
        {
            _authenticationProvider.Authenticate();
        }

        [Then(@"Background the IsAuthenticated should be true")]
        public void ThenBackgroundTheIsAuthenticatedShouldBeTrue()
        {
            Assert.True(_authenticationProvider.IsAuthenticated);
        }

        [Then(@"Background the Message should be (.*)")]
        public void ThenBackgroundTheMessageShouldBe_PO(string message)
        {
            Assert.Equal(message, _authenticationProvider.Message);
        }
    }
}
