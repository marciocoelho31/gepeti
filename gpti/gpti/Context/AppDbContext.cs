using gpti.Models;
using Microsoft.EntityFrameworkCore;

namespace gpti.Context
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cab> cab { get; set; }

    }
}
