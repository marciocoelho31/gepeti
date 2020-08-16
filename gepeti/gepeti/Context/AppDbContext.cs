using gepeti.Models;
using Microsoft.EntityFrameworkCore;

namespace gepeti.Context
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cab> cab { get; set; }

    }
}
