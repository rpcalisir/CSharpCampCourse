using Northwind.Business.Interface;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHybernate;
using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Business.Facade
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductDal();
        }
        
        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }
        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(productName));
        }
    }
}
