using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var configuration = new ConfigurationBuilder()
        //         .SetBasePath(Directory.GetCurrentDirectory())
        //         .AddJsonFile("appsettings.json")
        //         .Build();

        //     var connectionString = configuration.GetConnectionString("AppDb");
        //     optionsBuilder.UseSqlServer(connectionString);
        // } 
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Activity> Activities {get;set;}
    }
}