using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHybernate
{
    public class NhProductDal : IProductDal
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>
            {
               new Product{ProductId = 1,
                   CategoryId = 1,
                   ProductName = "ProductDemo",
                   QuantityPerUnit = "30 in a box",
                   ReorderLevel = 1,
                   SupplierId = 1,
                   UnitPrice = 30,
                   UnitsInStock = 100,
                   UnitsOnOrder = 15
               }
            };
            return products;
        }

        public Product GetProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
