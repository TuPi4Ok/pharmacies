using Microsoft.EntityFrameworkCore;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.config
{
    public class MyApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Discount> Discounts => Set<Discount>();
        public DbSet<Firm> Firms => Set<Firm>();
        public DbSet<Medicine> Medicines => Set<Medicine>();
        public DbSet<Pharmacy> Pharmacies => Set<Pharmacy>();
        public MyApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IVAN;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
