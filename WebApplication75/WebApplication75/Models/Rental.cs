using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication75.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Movies Movies { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }
    }
}