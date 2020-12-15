using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : DbContext, IProductDal
    {
        //public DbSet<Product> Products { get; set; }
        private IContext _context;

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
            using (_context = new NorthwindContext())
            {
                return _context.Products.ToList();
            }
        }

        public List<Category> GetAllCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
