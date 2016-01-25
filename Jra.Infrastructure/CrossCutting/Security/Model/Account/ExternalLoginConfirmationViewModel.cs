using System.ComponentModel.DataAnnotations;

namespace WebAppSoC.Infrastructure.Crosscutting.Security.Model.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
