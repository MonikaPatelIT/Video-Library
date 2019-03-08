using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    [RoutePrefix("Movie")]
    [Route("{action=index}")]
    public class MovieController : Controller
    {
        private BlogDbContext _context;

        public MovieController()
        {
            _context = new BlogDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //Get: Moive/Index
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);
            return View(movies);
        }

       


        [Route("Details/{id}")]
        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            if (movie == null)
            {
                return HttpNotFound();

            }
            else
            {
                return View(movie);
            }
        }

        public ActionResult MovieForm()
        {
            var genres = _context.Genre.ToList();
            var movieView = new MovieViewModel
            {
                Genres = genres
            };
            return View(movieView);
        }


        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieDb.Name = movie.Name;
                movieDb.ReleasedDate = movie.ReleasedDate;
                movieDb.Quantity = movie.Quantity;
                movieDb.GenreTypeId = movie.GenreTypeId;

            }
            _context.SaveChanges();

            return View("Index", "Movie");
        }
    }
}