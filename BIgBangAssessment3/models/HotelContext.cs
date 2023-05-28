using Microsoft.EntityFrameworkCore;

namespace BIgBangAssessment3.models
{
    public class HotelContext:DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
    }
}
