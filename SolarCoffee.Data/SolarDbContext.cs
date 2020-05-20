using System.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data {
    public class SolarDbContext : IdentityDbContext {
        public SolarDbContext() { }

        public SolarDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            // TODO: This is messy, but needed for migrations.
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=solardev;Password=solar123;Database=solardev;");
            
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }
        public virtual DbSet<ProductInventorySnapshot> ProductInventorySnapshots { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }
    }
}