using System.ComponentModel.DataAnnotations;

namespace ProjectFinal101.Core.Resources
{
    public class LoginResource
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "MIN_PASSWORD_LENGTH")]
        public string Password { get; set; }
    }
}
