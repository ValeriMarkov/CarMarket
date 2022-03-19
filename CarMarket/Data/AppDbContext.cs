using CarMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMarket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Office> Offices { get; set; }
    }
}
