using Microsoft.EntityFrameworkCore;
using Rasai_web.Models;

namespace Rasai_web
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
    }

}