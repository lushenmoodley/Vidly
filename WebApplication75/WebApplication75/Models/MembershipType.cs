using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication75.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SignUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
    }
}