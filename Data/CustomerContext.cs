using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using customer_consumption_api.Models;

namespace customer_consumption_api.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<CustomerLocation> CustomerLocations { get; set; }
        public DbSet<Meter> Meters { get; set; }
        public DbSet<MeterLocation> MeterLocations { get; set; }
        public DbSet<MeterInterval> MeterIntervals { get; set; }
        public DbSet<Weather> Weather {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerLocation>()
            .HasKey(o => new {o.CustomerId , o.LocationId});

            modelBuilder.Entity<MeterLocation>()
            .HasKey(o => new {o.MeterId , o.LocationId, o.ActiveDate});

            modelBuilder.Entity<MeterInterval>()
            .Property(p => p.ReadValue)
            .HasColumnType("decimal(7,4)");

            modelBuilder.Entity<CustomerLocation>()
            .Property(p => p.ServiceStart)
            .HasColumnType("Date");

            modelBuilder.Entity<CustomerLocation>()
            .Property(p => p.ServiceEnd)
            .HasColumnType("Date");

            modelBuilder.Entity<CustomerLocation>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<MeterLocation>()
            .Property(p => p.ActiveDate)
            .HasColumnType("Date");

            modelBuilder.Entity<MeterLocation>()
            .Property(p => p.InactiveDate)
            .HasColumnType("Date");

            modelBuilder.Entity<MeterInterval>()
            .Property(p => p.ReadDate)
            .HasColumnType("Date");

            modelBuilder.Entity<MeterInterval>()
            .Property(p => p.Id)
            .HasDefaultValueSql("newid()");

            modelBuilder.Entity<Weather>()
            .Property(p => p.ReadDate)
            .HasColumnType("Date");
        }


    }
}

