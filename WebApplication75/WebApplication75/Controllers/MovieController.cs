using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication75.ViewModel;
using WebApplication75.Models;
namespace WebApplication75.Controllers
{
    public class MovieController : Controller
    {
       private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var Movie = _context.Movies.Include(c=>c.Genre).ToList();

            var ViewModel = new MovieViewModel
            {
                GetMovies = Movie.ToList()
            };

            return View(ViewModel);
        }

        public ActionResult New()
        {
            var GenreTypes = _context.Genres.ToList();

            var ViewModel = new NewMovieModel
            {
                GenreType = GenreTypes
            };
          
            return View("New", ViewModel);
        }

        [HttpPost]/*this ensure the method is only called using httpPost not httpGet*/
        public ActionResult Create(Movies movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == m.Id);
                movieInDb.MovieName = movie.MovieName;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.Price = movie.Price;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.NumberAvaliable = movie.NumberAvaliable;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.SingleOrDefault(c => c.Id == id);

            if(movies== null)
            {
                return HttpNotFound();
            }

            var ViewModel = new NewMovieModel
            {
                Movie = movies,
                GenreType = _context.Genres.ToList()
            };

            return View("New", ViewModel);

        }
    }
}