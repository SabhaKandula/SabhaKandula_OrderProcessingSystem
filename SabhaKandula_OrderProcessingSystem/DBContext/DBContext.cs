using Microsoft.EntityFrameworkCore;
using SabhaKandula_OrderProcessingSystem.Models;

namespace SabhaKandula_OrderProcessingSystem.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
