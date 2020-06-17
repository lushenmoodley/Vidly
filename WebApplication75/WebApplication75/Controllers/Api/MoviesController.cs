using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication75.Models;

namespace WebApplication75.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;//context object to the database

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }
    }
}
