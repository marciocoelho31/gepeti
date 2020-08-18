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
        public DbSet<Agenda> agenda { get; set; }
        public DbSet<Pendencias> pendencias { get; set; }
        public DbSet<gpti.Models.RCP> RCP { get; set; }
        public DbSet<gpti.Models.Clientes> Clientes { get; set; }

    }
}
