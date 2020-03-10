using System;
using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class SigninModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Paswword")]
        public String Password { get; set; }

        [Display(Name = "RememberMe")]
        public Boolean RememberMe { get; set; }
    }
}
