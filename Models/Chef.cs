using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required(ErrorMessage ="First Name is required")]
        public string FirstName {get;set;}

        [Required(ErrorMessage ="Last Name is required")]
        public string LastName {get;set;}

        [Required(ErrorMessage ="Date of Birth is required")]
        [FutureDate]
        [DataType(DataType.Date)]
        [MinLength(18, ErrorMessage = "Minimum age is 18 years old")]
        public DateTime DOB {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List <Dish> MyDishes {get;set;}


        public class FutureDateAttribute : ValidationAttribute
        {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime check;
            if(value is DateTime)
            {
                check = (DateTime)value;
            }
            else
            {
                return new ValidationResult("Invalid");
            }
            if(check > DateTime.Now)
            {
                return new ValidationResult("Birthday must be in the past!");
            }
            return ValidationResult.Success;
        }


    }


    }
}