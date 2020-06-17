using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace WebApplication75.Models
{
    public class Min18YearsIfAMember:ValidationAttribute//this class is derived from validation attribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)//this method gives you access to other properties of your model
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.CustomerDateOfBirth==null)
            {
                return new ValidationResult("Birthdate is required");
            }

           /* var age = DateTime.Today.Year - Convert.ToInt16(customer.CustomerDateOfBirth);       

            if(age<18)
            {
               return new ValidationResult("The customer should be more that 18 years old to rent a movie");
            }*/
         
            if (customer.MembershipTypeId == MembershipType.unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo || customer.MembershipTypeId == MembershipType.Quartely || customer.MembershipTypeId == MembershipType.Annual)
            {                
               return ValidationResult.Success;
            }
                     
            return ValidationResult.Success;

        }

    }
}