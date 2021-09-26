using TechTalk.SpecFlow;
using Xunit;
using XunitSpecFlow.StepsContext;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageScopedSteps
    {
        private LoginAdminPageStepsContext _context { get; set; }
        public LoginAdminPageScopedSteps(LoginAdminPageStepsContext context)
        {
            _context = context;
        }

        [Given(@"Scoped the username is (.*)")]
        [Scope(Tag = "AuthenticationSuccessful")]
        public void GivenScopedTheUsernameIsCorrect_PO(string username)
        {
            _context.AuthenticationProvider.Username = username;
        }

        [Given(@"Scoped the password is (.*)")]
        [Scope(Tag = "AuthenticationSuccessful")]
        public void GivenScopedThePasswordIsCorrect_PO(string password)
        {
            _context.AuthenticationProvider.Password = password;
        }

        [Given(@"Scoped the username is (.*)")]
        [Scope(Tag = "AuthenticationFailed")]
        public void GivenScopedTheUsernameIsWrong_PO(string username)
        {
            _context.AuthenticationProvider.Username = username;
        }

        [Given(@"Scoped the password is (.*)")]
        [Scope(Tag = "AuthenticationFailed")]
        public void GivenScopedThePasswordIsWrong_PO(string password)
        {
            _context.AuthenticationProvider.Password = password;
        }

        [When(@"Scoped trigger login")]
        public void WhenScopedTriggerLogin()
        {
            _context.AuthenticationProvider.Authenticate();
        }

        [Then(@"Scoped the IsAuthenticated should be (.*)")]
        public void ThenScopedTheIsAuthenticatedShouldBe_PO(bool isAuthenticated)
        {
            Assert.Equal(isAuthenticated, _context.AuthenticationProvider.IsAuthenticated);
        }

        [Then(@"Scoped the Message should be (.*)")]
        public void ThenScopedTheMessageShouldBe_PO(string message)
        {
            Assert.Equal(message, _context.AuthenticationProvider.Message);
        }
    }
}
