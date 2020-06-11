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

        //defining the membership type here
        public static readonly int unknown = 0;
        public static readonly int PayAsYouGo = 1;
        public static readonly int Quartely = 2;
        public static readonly int Annual = 3;

    }
}