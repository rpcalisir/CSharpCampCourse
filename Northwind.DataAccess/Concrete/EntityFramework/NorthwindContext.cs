using System.Data.Entity;
using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;


namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext, IContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
