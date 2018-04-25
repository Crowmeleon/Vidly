using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Shrek"
            };
            var customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Andrea"
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Peter"
                }
            };

            var randomData = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomData);
        }

        //[Route("movies/released/{year:regex(//d{4})}/{month:regex(//d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{

        //    return Content(year + "/" + month);
        //}
    }
}