using gpti.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace gpti.Context
{

    //public class AppDbContext : DbContext
    [System.Data.Entity.DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AppDbContext : IdentityDbContext<IdentityUser>     /* dessa forma ele cria no banco de dados as tabelas referentes a autenticacao */
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cab> Cab { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Pendencias> Pendencias { get; set; }
        public DbSet<gpti.Models.RCP> RCP { get; set; }
        public DbSet<gpti.Models.Clientes> Clientes { get; set; }

    }
}
