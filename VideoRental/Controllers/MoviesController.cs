using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;
using VideoRental.ViewModels;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name="Shrek"},
                new Movie {Id =2, Name = "Wall-E"}
            };
        }
        // GET: Movies


        public ActionResult Random()
        {

            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-E"}
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "James Smith"},
                new Customer {Name = "Jane Doe"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movies,
                Customers = customers
            };

            return View(viewModel); 
        }

        [Route("movies/released/{year}/{month:range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }


}