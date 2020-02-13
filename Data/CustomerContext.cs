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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}

