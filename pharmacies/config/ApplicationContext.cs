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
        public DbSet<Pharmacy> Pharmacys => Set<Pharmacy>();

        public DbSet<PharmacyMedicine> PharmacyMedicines => Set<PharmacyMedicine>();
        public MyApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IVAN;Database=helloappdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firm>()
                .HasMany(u => u.Medicines)
                .WithOne(u => u.Firm)
                .HasForeignKey(u => u.FirmId);

            modelBuilder.Entity<Medicine>()
                .HasOne<Discount>(u => u.Discount)
                .WithOne(u => u.Medicine)
                .HasForeignKey<Discount>(u => u.Id);


            modelBuilder.Entity<PharmacyMedicine>().HasKey(sc => new { sc.MedicineId, sc.PharmacyId });

            modelBuilder.Entity<PharmacyMedicine>()
                .HasOne(u => u.Medicine)
                .WithMany(u => u.PharmacyMedicine)
                .HasForeignKey(u => u.MedicineId);

            modelBuilder.Entity<PharmacyMedicine>()
                .HasOne(u => u.Pharmacy)
                .WithMany(u => u.PharmacyMedicine)
                .HasForeignKey(u => u.PharmacyId);

        }
    }
}
