using Authentication;
using TechTalk.SpecFlow;

namespace XunitSpecFlow.StepsContext
{
    [Binding]
    public class LoginAdminPageStepsContext
    {
        public AuthenticationProvider AuthenticationProvider { get; set; }

        [Given(@"I access the authentication page")]
        public void GivenStepsContextIAccessTheAuthenticationPage()
        {
            AuthenticationProvider = new AuthenticationProvider();
        }
    }
}
