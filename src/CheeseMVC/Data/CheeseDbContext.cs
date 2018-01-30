using System.Collections.Generic;
using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        public DbSet<Cheese> Cheeses { get; set; }
        //EF will create a table called Categories
        public DbSet<CheeseCategory> Categories { get; set; }
        public List<Cheese> Include { get; internal set; }

        public CheeseDbContext(DbContextOptions<CheeseDbContext> options) 
            : base(options)
        { }

    }
}
