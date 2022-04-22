using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage ="Name is required")]
        [MinLength(2, ErrorMessage ="Name must be at least two characters")]
        public string Name {get;set;}


        [Required(ErrorMessage ="Tastiness is required")]
        [Range(1, 10)]
        public int Tastiness {get;set;}

        [Required(ErrorMessage ="Calories is required")]
        [Range(1, 5000, ErrorMessage ="Calories must be more than 1")]
        public int Calories {get;set;}

        [Required(ErrorMessage ="Description is required")]
        [MinLength(2, ErrorMessage ="Description must be at least two characters")]
        public string Description {get;set;}

        public int ChefId {get;set;}

        public Chef MyChef {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        

    }
}