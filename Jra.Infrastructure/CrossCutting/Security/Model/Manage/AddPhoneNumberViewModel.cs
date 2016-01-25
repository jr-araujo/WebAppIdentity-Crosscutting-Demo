using System.ComponentModel.DataAnnotations;

namespace WebAppSoC.Infrastructure.Crosscutting.Security.Model.Manage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}