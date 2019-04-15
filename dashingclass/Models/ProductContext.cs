using System.Data.Entity;

namespace dashingclass.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DashingClass")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}