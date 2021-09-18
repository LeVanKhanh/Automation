using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Selenium.Models
{
    public class LoginViewModel
    {
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Password")]
        [Required]
        public string Password { get; set; }
    }
}
