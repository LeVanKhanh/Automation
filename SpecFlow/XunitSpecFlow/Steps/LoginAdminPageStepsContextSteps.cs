using TechTalk.SpecFlow;
using Xunit;
using XunitSpecFlow.StepsContext;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageStepsContextSteps
    {
        private LoginAdminPageStepsContext _context { get; set; }
        public LoginAdminPageStepsContextSteps(LoginAdminPageStepsContext context)
        {
            _context = context;
        }

        [Given(@"StepsContext the username is (.*)")]
        public void GivenStepsContextTheUsernameIs_PO(string username)
        {
            _context.AuthenticationProvider.Username = username;
        }

        [Given(@"StepsContext the password is (.*)")]
        public void GivenStepsContextThePasswordIs_PO(string password)
        {
            _context.AuthenticationProvider.Password = password;
        }

        [When(@"StepsContext trigger login")]
        public void WhenStepsContextTriggerLogin()
        {
            _context.AuthenticationProvider.Authenticate();
        }

        [Then(@"StepsContext the IsAuthenticated should be (.*)")]
        public void ThenStepsContextTheIsAuthenticatedShouldBe_PO(bool isAuthenticated)
        {
            Assert.Equal(isAuthenticated, _context.AuthenticationProvider.IsAuthenticated);
        }

        [Then(@"StepsContext the Message should be (.*)")]
        public void ThenStepsContextTheMessageShouldBe_PO(string message)
        {
            Assert.Equal(message, _context.AuthenticationProvider.Message);
        }
    }
}
