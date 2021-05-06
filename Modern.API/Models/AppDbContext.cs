using Microsoft.EntityFrameworkCore;
using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                CustomerCategory = CustomerCategory.B2B,
                CustomerName = "XYZ Business Ltd.",
                Street = "Elvis Lane",
                PostCode = "TW16",
                City = "London",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 2,
                CustomerCategory = CustomerCategory.B2C,
                CustomerName = "ABC Informatics Ltd.",
                Street = "Bankers street",
                PostCode = "TW03",
                City = "London",
            });
        }
    }
}
