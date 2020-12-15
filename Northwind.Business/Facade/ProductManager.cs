using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHybernate;
using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Business.Facade
{
    public class ProductManager
    {
        private readonly IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductDal();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAllProducts();
        }

        public List<Category> GetAllCategories()
        {
            return _productDal.GetAllCategories().ToList();
        }

        public List<Product> SearchByCategory(int categoryId)
        {
            return _productDal.GetAllProducts().Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
