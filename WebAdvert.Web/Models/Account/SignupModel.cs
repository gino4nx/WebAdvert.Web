using System;
using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least six characters long!")]
        [Display(Name = "Paswword")]
        public String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Paswword")]
        [Compare("Password", ErrorMessage = "Password and its confirmation do not match")]
        public String ConfirmPassword { get; set; }
    }
}
