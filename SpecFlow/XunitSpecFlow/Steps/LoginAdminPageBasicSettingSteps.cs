using Authentication;
using TechTalk.SpecFlow;
using Xunit;

namespace XunitSpecFlow.Steps
{
    [Binding]
    public class LoginAdminPageBasicSettingSteps
    {
        private AuthenticationProvider _authenticationProvider { get; set; }
        public LoginAdminPageBasicSettingSteps()
        {
            _authenticationProvider = new AuthenticationProvider();
        }

        [Given(@"BasicSetting the username is admin")]
        public void GivenTheUsernameIsAdmin()
        {
            _authenticationProvider.Username = "admin";
        }
        
        [Given(@"BasicSetting the password is admin")]
        public void GivenThePasswordIsAdmin()
        {
            _authenticationProvider.Password = "admin";
        }
        
        [Given(@"BasicSetting the username is administrator")]
        public void GivenTheUsernameIsAdministrator()
        {
            _authenticationProvider.Username = "administrator";
        }
        
        [Given(@"BasicSetting the password is administrator")]
        public void GivenThePasswordIsAdministrator()
        {
            _authenticationProvider.Password = "administrator";
        }
        
        [Given(@"BasicSetting the username is superadmin")]
        public void GivenTheUsernameIsSuperadmin()
        {
            _authenticationProvider.Username = "superadmin";
        }
        
        [Given(@"BasicSetting the password is superadmin")]
        public void GivenThePasswordIsSuperadmin()
        {
            _authenticationProvider.Password = "superadmin";
        }
        
        [Given(@"BasicSetting the username is superadministrator")]
        public void GivenTheUsernameIsSuperadministrator()
        {
            _authenticationProvider.Username = "superadministrator";
        }
        
        [Given(@"BasicSetting the password is superadministrator")]
        public void GivenThePasswordIsSuperadministrator()
        {
            _authenticationProvider.Password = "superadministrator";
        }
        
        [Given(@"BasicSetting the username is null")]
        public void GivenTheUsernameIsNull()
        {
            _authenticationProvider.Username = null;
        }
        
        [Given(@"BasicSetting the password is null")]
        public void GivenThePasswordIsNull()
        {
            _authenticationProvider.Password = null;
        }
        
        [Given(@"BasicSetting the username is admim")]
        public void GivenTheUsernameIsAdmim()
        {
            _authenticationProvider.Username = "admim";
        }
        
        [Given(@"BasicSetting the password is admim")]
        public void GivenThePasswordIsAdmim()
        {
            _authenticationProvider.Password = "admim";
        }
        
        [When(@"BasicSetting trigger login")]
        public void WhenTriggerLogin()
        {
            _authenticationProvider.Authenticate();
        }
        
        [Then(@"BasicSetting the IsAuthenticated should be true")]
        public void ThenTheIsAuthenticatedShouldBeTrue()
        {
            Assert.True(_authenticationProvider.IsAuthenticated);
        }
        
        [Then(@"BasicSetting the Message should be The username and password are requied!")]
        public void ThenTheMessageShouldBeTheUsernameAndPasswordAreRequied()
        {
            Assert.Equal("The username and password are requied!", _authenticationProvider.Message);
        }
        
        [Then(@"BasicSetting the Message should be The username or password is incorrect!")]
        public void ThenTheMessageShouldBeTheUsernameOrPasswordIsIncorrect()
        {
            Assert.Equal("The username or password is incorrect!", _authenticationProvider.Message);
        }
    }
}
