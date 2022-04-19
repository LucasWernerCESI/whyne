using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Whyne.DAL.Orders;
using Whyne.DAL.People;
using Whyne.DAL.Products;
using Whyne.Models.People;

namespace Whyne.DAL
{
    public class WhyneContext : IdentityDbContext<IdentityUser>
    {
        // DbSets
        public DbSet<Corporation> Corporations { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<SupplierOrder> SupplierOrders { get; set; }

        // Configuration
        private readonly string _dbPath = @"Server=localhost;Port=3306;Database=Whyne;Uid=root;Pwd=123456";
        public MariaDbServerVersion DbServerVersion { get; private set; }

        public WhyneContext() : base()
        {
            DbServerVersion = new MariaDbServerVersion(new Version(10, 6, 5));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(_dbPath, DbServerVersion);
    }
}