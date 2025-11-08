using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required, MinLength(3),MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password do not match")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }
    }
}
