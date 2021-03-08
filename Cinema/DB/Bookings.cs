using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cinema.DB
{
    public partial class Bookings
    {
        public int Id { get; set; }
        public int MoviesId { get; set; }
        public int Price { get; set; }
        public string SeatType { get; set; }
        public string UserName { get; set; }
        public string AuditoriumName { get; set; }
        public int AuditoriumCapacity { get; set; }
    }
}
