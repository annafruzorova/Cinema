using Cinema;
using Cinema.Logic;
using System;

namespace Cinema.Console
{
    
    class Program
    {
        private static BookingManager bookings = new BookingManager();
        private static MoviesManager movies = new MoviesManager();
        static void Main(string[] args)
        {
            System.Console.WriteLine("Movies: ");
            movies.GetAllMovies().ForEach(m =>
            {
                System.Console.WriteLine(m.Name);
            });

            System.Console.WriteLine("Bookings: ");
            bookings.GetUserBookings().ForEach(b =>
            {
                System.Console.WriteLine(b.MoviesId);
            });
        }
    }
}
