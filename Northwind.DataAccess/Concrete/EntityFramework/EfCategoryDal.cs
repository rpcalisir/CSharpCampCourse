using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : DbContext
    {
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> FetchProducts()
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        public List<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
