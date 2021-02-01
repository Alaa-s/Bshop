using bakaryshop.Configerations;
using bakaryshop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakaryshop.Data
{
    public class BakeryShopContext :DbContext
    {
        public DbSet<Product> products { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configer db context sql lite
            optionsBuilder.UseSqlite(@"Data Source = BakreyDB.db");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfigration()).Seed();
        }
    }
}
