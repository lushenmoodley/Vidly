using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication75.DTO;
using WebApplication75.Models;

namespace WebApplication75.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;//context object to the database

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            
            var customer = _context.Customers.Single(c => c.CustomerId == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));
                        
            foreach(var movie in movies)
            {
                if(movie.NumberAvaliable==0)

                    return BadRequest("Movie is not avaliable");
                
                movie.NumberAvaliable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movies = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
