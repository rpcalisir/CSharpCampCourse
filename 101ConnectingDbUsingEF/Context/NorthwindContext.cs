using _101ConnectingDbUsingEF.Entities;
using System.Data.Entity;

namespace _101ConnectingDbUsingEF.Context
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
