using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class SignUpVM
    {
        [MaxLength(100, ErrorMessage = "So Large User Name")]
        [MinLength(1, ErrorMessage = "So Small User Name")]
        public string UserName { get; set; }

        [MaxLength(100, ErrorMessage = "So Large FirstName")]
        [MinLength(3, ErrorMessage = "So Small FirstName")]
        [Required(ErrorMessage = "FirstName Required")]
        public string FirstName { get; set; }

        [MaxLength(100, ErrorMessage = "So Large LastName")]
        [MinLength(3, ErrorMessage = "So Small LastName")]
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Select Gender.")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Password Format is Valid")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [Required(ErrorMessage = "ConfirmPassword is required.")]
        public string ConfirmPassword { get; set; }

    }
}
