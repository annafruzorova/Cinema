using Cinema.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class BookingManager
    {
        public List<Bookings> GetUserBookings()
        {

            using (var db = new CinemaDB())
            {
                return db.Bookings.OrderBy(b => b.MoviesId).ToList();
            }


        }
    }
}
