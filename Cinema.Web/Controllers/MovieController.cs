using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Logic;
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

        public IActionResult CancelBooking(int moviesId)
        {
            manager.CancelBooking(moviesId);

            
            return RedirectToAction(nameof(MyMovies));
        }
    }
}
