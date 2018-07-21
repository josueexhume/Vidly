using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Account.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Drivers License Number")]
        public string DriverLicenseNo { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}