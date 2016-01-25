using System.ComponentModel.DataAnnotations;

namespace WebAppSoC.Infrastructure.Crosscutting.Security.Model.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}