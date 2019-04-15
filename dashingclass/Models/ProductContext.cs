using System.Data.Entity;

namespace dashingclass.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DashingClass")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}