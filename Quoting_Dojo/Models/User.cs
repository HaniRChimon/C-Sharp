using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore;
namespace Quoting_Dojo.Models
{
    public class User
    {
            [Key]
        public int UserId { get; set; }

        [Required]
        [Display(Name="Your Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters!")]
        public string UserName { get; set; }

        [Required]
        [Display(Name="Your Quote")]
        [DataType(DataType.MultilineText)]
        [MaxLength(100)]
        [MinLength(10, ErrorMessage="Your Quote MUST be 10 characters long!!!")]
        public string UserQuote {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}