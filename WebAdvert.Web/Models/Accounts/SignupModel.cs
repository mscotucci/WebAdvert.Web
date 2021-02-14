using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(6,ErrorMessage ="Password 6 caratteri")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password 6 caratteri")]
        [Compare(nameof(Password),ErrorMessage = "Password non corrispondenti")]
        [Display(Name = "Conferma Password")]
        public string ConfirmPassword { get; set; }
        
    }
}
