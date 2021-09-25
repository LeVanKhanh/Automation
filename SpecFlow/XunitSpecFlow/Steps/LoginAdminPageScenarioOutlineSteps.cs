using Authentication;
using TechTalk.SpecFlow;
using Xunit;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageScenarioOutlineSteps
    {
        private AuthenticationProvider _authenticationProvider { get; set; }
        public LoginAdminPageScenarioOutlineSteps()
        {
            _authenticationProvider = new AuthenticationProvider();
        }

        [Given(@"ScenarioOutline the username is (.*)")]
        public void GivenScenarioOutlineTheUsernameIs_PO(string username)
        {
            _authenticationProvider.Username = username;
        }

        [Given(@"ScenarioOutline the password is (.*)")]
        public void GivenScenarioOutlineThePasswordIs_PO(string password)
        {
            _authenticationProvider.Password = password;
        }

        [When(@"ScenarioOutline trigger login")]
        public void WhenScenarioOutlineTriggerLogin()
        {
            _authenticationProvider.Authenticate();
        }

        [Then(@"ScenarioOutline the IsAuthenticated should be true")]
        public void ThenScenarioOutlineTheIsAuthenticatedShouldBeTrue()
        {
            Assert.True(_authenticationProvider.IsAuthenticated);
        }

        [Then(@"ScenarioOutline the Message should be (.*)")]
        public void ThenScenarioOutlineTheMessageShouldBe_PO(string message)
        {
            Assert.Equal(message, _authenticationProvider.Message);
        }
    }
}
