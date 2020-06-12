using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication75.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Date Of Birth")]
        [Min18YearsIfAMember]
        public Nullable<DateTime> CustomerDateOfBirth { get; set; } 

        public bool IsSubscribed { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
    }
}