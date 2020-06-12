using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Chefs_n_Dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}


        [Required(ErrorMessage="Chef first name is required")]
        public string FirstName {get; set;}


        [Required(ErrorMessage="Chef last name is required")]
        public string LastName {get; set;}


        [Required(ErrorMessage="Birthday is required")]
        public DateTime Birthday {get; set;}

        public List<Dish> CreatedDishes {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}