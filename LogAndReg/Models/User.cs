using System;
using System.ComponentModel.DataAnnotations;

namespace LogAndReg.Models
{
    public class User
    {
        [Required (ErrorMessage="You have to have a First Name!!")]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [Display (Name="Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="Confim Password")]
        public string ConfirmPassword { get; set; }

    }
}