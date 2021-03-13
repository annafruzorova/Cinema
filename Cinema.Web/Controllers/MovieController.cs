using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Logic;
using Cinema.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Controllers
{
    public class MovieController : Controller
    {
        private static Manager manager = new Manager();
        public IActionResult Index()
        {
            var movies = manager.GetAllMovies();

            return View(movies);
        }

        //public IActionResult Movies (int? id)
        //{
        //    MoviesModel model = new MoviesModel();
        //    model.Movies = manager.GetAllMovies();
        //    if (id.HasValue)
        //    {
                
        //        model.ActiveMovies = manager.GetMovies(id.Value);
                
        //        model.UserBookings = manager.GetByCategory(id.Value);
        //    }

        //    return View(model);
        //}

        public IActionResult MyMovies()
        {
            var movies = manager.GetUserBookings();

            return View(movies);
        }
        public IActionResult CreateBooking(string name)
        {
            manager.CreateBooking(name);

            return RedirectToAction(nameof(MyMovies));
        }

        public IActionResult CancelBooking(string name)
        {
            manager.CancelBooking(name);

            
            return RedirectToAction(nameof(MyMovies));
        }
    }
}
