using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class User_CU_VM
    {
        public string Id { get; set; }

        [MaxLength(100, ErrorMessage = "So Large Image Name")]
        [MinLength(1, ErrorMessage = "So Small Image Name")]
        public string Image { get; set; }

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
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email formatı is valid")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Password Formatı is Valid")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }

        public IFormFile Photo { get; set; }

        public List<IdentityRole> Roles { get; set; }

        public List<string> RolIds { get; set; }
    }
}
