using Cinema.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class Manager
    {
        public List<Bookings> GetUserBookings()
        {

            using (var db = new CinemaDB())
            {
                return db.Bookings.OrderBy(b => b.MoviesId).ToList();
            }
        }

        public List<Movies> GetAllMovies()
        {

            using (var db = new CinemaDB())
            {
                return db.Movies.OrderBy(m => m.Category).ToList();
            }
        }
        public Movies CreateBooking(string name)
        {
            using (var db = new CinemaDB())
            {
                var movie = db.Movies.FirstOrDefault(m => m.Name.ToLower() == name.ToLower());
                if (movie.AvailableTime != null)
                {

                    db.Bookings.Add(new Bookings()
                    {
                        MoviesId = movie.Id
                    });

                    db.SaveChanges();

                    return movie;
                }
            }

            return null;
        }

        public Bookings CancelBooking(int moviesId)
        {
            using (var db = new CinemaDB())
            {
                var booking = db.Bookings.FirstOrDefault(b => b.MoviesId == moviesId);
                if (booking != null)
                {
                    db.Bookings.Remove(booking);

                    db.SaveChanges();

                    return booking;
                }
            }

            return null;
        }
    }
    }

