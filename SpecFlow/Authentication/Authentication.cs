using System.Collections.Generic;
using System.Linq;

namespace Authentication
{
    public class AuthenticationProvider
    {
        private static Dictionary<string, string> AdminAccounts { get; } = new Dictionary<string, string>
        {
            {"admin", "admin" },
            {"administrator", "administrator" },
            {"superadmin", "superadmin" },
            {"superadministrator", "superadministrator" }
        };

        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Message { get; set; }
        public void Authenticate()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                Message = "The username and password are requied!";
                return;
            }

            IsAuthenticated = AdminAccounts.Any(a => a.Key.Equals(Username, System.StringComparison.OrdinalIgnoreCase)
                && a.Value.Equals(Password, System.StringComparison.OrdinalIgnoreCase));

            if (!IsAuthenticated)
            {
                Message = "The username or password is incorrect!";
            }
        }
    }
}
