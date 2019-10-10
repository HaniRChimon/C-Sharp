using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelecious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get;set;}
        [Required]
        [Display(Name="Chef's Name")]
        public string ChefName { get; set;}
        [Required]
        [Display(Name="Name of Dish")]
        public string DishName {get;set;}
        [Required]
        [Range(1,Int32.MaxValue)]
        public int Calories {get;set;}
        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}
        [Required]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;}= DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}