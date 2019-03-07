using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    [RoutePrefix("Movie")]
    [Route("{action=index}")]
    public class MovieController : Controller
    {

        //Get: Moive/Index
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        // GET: Moive/Random
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie(){ Name = "Bagban" }
            };
            var customers = new List<Customer>
          {
              new Customer(){Name="Monika"},
              new Customer(){Name="Hiren"}
          };
            var randomView = new RandomViewModel
            {
                Movies = movie,
                Customers = customers
            };
            return View(randomView);
        }


        [Route("Details/{id}")]
        public ActionResult MovieById(int Id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == Id);
            if (movie == null)
            {
                return HttpNotFound();

            }
            else
            {
                return View(movie);
            }
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1,Name ="Hera pheri"},
                new Movie {Id=2, Name ="Phir Hera pheri"}
            };

        }
      

       
    }
}