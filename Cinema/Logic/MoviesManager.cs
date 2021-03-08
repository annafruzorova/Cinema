using Cinema.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class MoviesManager
    {
        public List<Movies> GetAllMovies()
        {

            using (var db = new CinemaDB())
            {
                return db.Movies.OrderBy(m => m.Name).ToList();
            }
        }
    }
}
