using Microsoft.EntityFrameworkCore;
using APIBookMyShowD.Entities;

namespace APIBookMyShowD.Database
{
    public class MyContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Role > Roles { get; set; }

        public DbSet< Movie > Movies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet< Wallet > Wallets { get; set; }

        public DbSet<Multiplex > Multiplexes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= DESKTOP-30U1UJQ\\SQLEXPRESS01; Initial Catalog=BooksMyShowService;User Id=Varaprasad;Password=12345;TrustServerCertificate=true");
        }

    }
}
