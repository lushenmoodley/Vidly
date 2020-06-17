using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebApplication75.Models;

namespace WebApplication75.DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }
        public Nullable<DateTime> CustomerDateOfBirth { get; set; }
        public bool IsSubscribed { get; set; }
        public int MembershipTypeId { get; set; }
    }
}