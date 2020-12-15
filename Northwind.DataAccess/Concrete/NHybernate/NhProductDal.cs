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
        public void AddToDb(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
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

        public Product GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateInDb(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteInDb(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
