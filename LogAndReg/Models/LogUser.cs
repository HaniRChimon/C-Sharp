using System;
using System.ComponentModel.DataAnnotations;
namespace LogAndReg.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string LoginEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}