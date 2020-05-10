using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopOfProd.Models;

namespace ShopOfProd.Context
{
    class MyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public MyDbContext() : base("DBConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set;}
        public DbSet<CategoryProducts> CategoryProduct { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
