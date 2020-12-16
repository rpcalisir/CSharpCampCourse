using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHybernate
{
    public class NhProductDal : IProductDal
    {
        public void AddToDb(Product entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteInDb(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
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

        public void UpdateInDb(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
