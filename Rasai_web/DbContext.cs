using Microsoft.EntityFrameworkCore;
using Rasai_web.Models;

namespace Rasai_web
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
    }


}






