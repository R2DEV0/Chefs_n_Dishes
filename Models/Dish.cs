using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs_n_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}


        [Required(ErrorMessage="This is required")]
        public string Name {get; set;}


        [Required(ErrorMessage="This is required")]
        [Range(0, 10000000)]
        public int? Calories {get; set;}


        [Required(ErrorMessage="This is required")]
        public string Description {get; set;}


        [Required(ErrorMessage="This is required")]
        public int? Taste {get; set;}

        [Required]
        public int ChefId {get; set;}

        public Chef Creator {get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}