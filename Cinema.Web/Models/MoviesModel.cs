using Cinema.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Models
{
    public class MoviesModel
    {
        public List<Movies> Movies { get; set; }

        public List<UserBookings> UserBookings { get; set; }

        public Movies ActiveMovies { get; set; }
    }
}
