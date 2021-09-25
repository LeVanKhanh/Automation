using Authentication;
using TechTalk.SpecFlow;
using Xunit;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageSharedStepsSteps
    {
        private AuthenticationProvider _authenticationProvider { get; set; }
        public LoginAdminPageSharedStepsSteps()
        {
            _authenticationProvider = new AuthenticationProvider();
        }

        [Given(@"SharedSteps the username is (.*)")]
        public void GivenSharedStepsTheUsernameIs_PO(string username)
        {
            _authenticationProvider.Username = username;
        }

        [Given(@"SharedSteps the password is (.*)")]
        public void GivenSharedStepsThePasswordIs_PO(string password)
        {
            _authenticationProvider.Password = password;
        }
        
        [When(@"SharedSteps trigger login")]
        public void WhenSharedStepsTriggerLogin()
        {
            _authenticationProvider.Authenticate();
        }
        
        [Then(@"SharedSteps the IsAuthenticated should be true")]
        public void ThenSharedStepsTheIsAuthenticatedShouldBeTrue()
        {
            Assert.True(_authenticationProvider.IsAuthenticated);
        }
        
        [Then(@"SharedSteps the Message should be (.*)")]
        public void ThenSharedStepsTheMessageShouldBe_PO(string message)
        {
            Assert.Equal(message, _authenticationProvider.Message);
        }

        [Given(@"Sleep (.* days ago)")]
        public void GivenSleepDaysAgo(string p0)
        {
            
        }

    }
}
