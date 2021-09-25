using Authentication;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageTableSteps
    {
        private AuthenticationProvider _authenticationProvider { get; set; }
        public LoginAdminPageTableSteps()
        {
            _authenticationProvider = new AuthenticationProvider();
        }

        [Given(@"Table I have successful authentication with correct account")]
        public void GivenIHaveSuccessfulAuthenticationWithCorrectAccount(Table table)
        {
            _authenticationProvider.Username = table.Rows.First(r => r["attribute"] == "username")["value"];
            _authenticationProvider.Password = table.Rows.First(r => r["attribute"] == "password")["value"];
        }

        [Given(@"Table I have failed authentication with incorrect account")]
        public void GivenIHaveFailedAuthenticationWithIncorrectAccount(Table table)
        {
            _authenticationProvider.Username = table.Rows.First(r => r["attribute"] == "username")["value"];
            _authenticationProvider.Password = table.Rows.First(r => r["attribute"] == "password")["value"];
        }

        [Given(@"Table I have failed authentication with missing input")]
        public void GivenIHaveFailedAuthenticationWithMissingInput(Table table)
        {
            _authenticationProvider.Username = table.Rows.First(r => r["attribute"] == "username")["value"];
            _authenticationProvider.Password = table.Rows.First(r => r["attribute"] == "password")["value"];
        }

        [When(@"Table trigger login")]
        public void WhenTableTriggerLogin()
        {
            _authenticationProvider.Authenticate();
        }

        [Then(@"Table the IsAuthenticated should be true")]
        public void ThenTableTheIsAuthenticatedShouldBeTrue()
        {
            Assert.True(_authenticationProvider.IsAuthenticated);
        }

        [Then(@"Table the Message should be (.*)")]
        public void TableTheMessageShouldBe_PO(string message)
        {
            Assert.Equal(message, _authenticationProvider.Message);
        }
    }
}
