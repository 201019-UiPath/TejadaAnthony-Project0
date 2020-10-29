using Microsoft.EntityFrameworkCore;
using StoreAppLib.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace StoreAppDB
{
    public class StoreAppContext : DbContext
    {
        //entities

        public DbSet<Employees> Employees {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if(!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

                var connectionString = configuration.GetConnectionString("StoreAppDb");

                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}