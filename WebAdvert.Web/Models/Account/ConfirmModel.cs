using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class ConfirmModel
    {
        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public String Code { get; set; }
    }
}
