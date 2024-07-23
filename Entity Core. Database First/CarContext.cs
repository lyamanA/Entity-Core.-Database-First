using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;
using System.Configuration;

namespace Entity_Core._Database_First
{
    internal class CarContext : DbContext
    {
        string connectionString = ConfigurationManager
             .ConnectionStrings["DefaultConnectionString"]
             .ConnectionString;
        public DbSet<Car> Car { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

       
    }
}
