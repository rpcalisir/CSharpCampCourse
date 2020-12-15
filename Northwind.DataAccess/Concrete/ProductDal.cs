using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Northwind.DataAccess.Concrete
{
    public class ProductDal : DbContext
    {
        //public DbSet<Product> Products { get; set; }
        public List<Product> GetAllProducts()
        {
            return FetchProducts().ToList();
        }

        public Product GetProduct(int productId)
        {
            return FetchProducts().Where(p => p.ProductId == productId).FirstOrDefault();
        }

        public void AddProduct(Product product)
        {
            
        }

        private List<Product> FetchProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

    }
}
