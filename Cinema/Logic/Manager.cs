using Cinema.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class Manager 
    {
    
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

                    db.UserBookings.Add(new UserBookings()
                    {
                        Category = movie.Category,
                        Name = movie.Name,
                        AvailableTime = movie.AvailableTime
                        
                    });

                    db.SaveChanges();

                    return movie;
                }
            }

            return null;
        }

        public Movies GetMovies(int id)
        {
            using (var db = new CinemaDB())
            {
                return db.Movies.FirstOrDefault(m => m.Id == id);
            }
        }


        public List<UserBookings> GetUserBookings()
        {

            using (var db = new CinemaDB())
            {
                return db.UserBookings.OrderBy(b => b.Name).ToList();
            }
        }

        public UserBookings CancelBooking(string name)
        {
            using (var db = new CinemaDB())
            {
                var booking = db.UserBookings.FirstOrDefault(b => b.Name.ToLower() == name.ToLower());
                if (booking != null)
                {
                    db.UserBookings.Remove(booking);

                    db.SaveChanges();

                    return booking;
                }
            }

            return null;
        }

        public List<UserBookings> GetByCategory(int moviesId)
        {
            using (var db = new CinemaDB())
            {
                return db.UserBookings

                    .Where(b => b.MoviesId == moviesId)

                    .OrderByDescending(b => b.Category)
                    .ToList();
            }
        }


    }
    }

