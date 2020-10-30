using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StoreAppDB.Models
{
    public class StoreAppContext : DbContext
    {
        //entities

        public DbSet<Manager> Managers {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Inventory> Inventory {get;set;}
        public DbSet<Location> Locations {get;set;}
        public DbSet<BaseballBat> BaseballBats {get;set;}
        public DbSet<Orders> Orders {get;set;}
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            //if no connection to database configure one 
            if(!optionsBuilder.IsConfigured)
            {
                //look for json file to configure 
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


                var connectionString = configuration.GetConnectionString("StoreAppDb");

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //     modelBuilder.Entity<Inventory>()
        //     .HasOne(e => e.Locations)
        //     .WithMany(c => c.Products);

        // }
    }
}