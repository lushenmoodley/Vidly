using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication75.Models;

namespace WebApplication75.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}