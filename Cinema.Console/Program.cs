using Cinema;
using Cinema.Logic;
using System;

namespace Cinema.Console
{
    
    class Program
    {
        private static Manager manager = new Manager();
       


        static void Main(string[] args)
        {
            System.Console.WriteLine("Movies: ");
            manager.GetAllMovies().ForEach(m =>
            {
                System.Console.WriteLine(m.Name, m.Category, m.AvailableTime);
            });



            while (true)
            {
                System.Console.Write("Enter movies's name (or stop): ");
                string input = System.Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                var movie = manager.CreateBooking(input);
                if (movie != null)
                {
                    System.Console.WriteLine($"Now you have a booking on {movie.Name} at {movie.AvailableTime}");
                }
                else
                {
                   
                    System.Console.WriteLine("Movie is not available!");
                }
            }



            System.Console.WriteLine("Bookings: ");
            manager.GetUserBookings().ForEach(b =>
            {
                System.Console.WriteLine(b.Name, b.Category, b.AvailableTime);
            });



            System.Console.WriteLine("Would you like to cancel this booking?");
            while (true)
            {
                System.Console.Write("Enter movies's name (or stop): ");
                string input = System.Console.ReadLine();
                
                if (input == "stop")
                {
                    break;
                }

                var movie = manager.CancelBooking(input);
                if (movie != null)
                {
                    System.Console.WriteLine($"Movie {movie.Name} was succesfully cancel");
                }
                else
                {
                  
                    System.Console.WriteLine("You don't have this bookïng!");
                }
            }
        }
    }


    }

