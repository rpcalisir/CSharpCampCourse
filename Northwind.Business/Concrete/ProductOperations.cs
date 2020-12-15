using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Business.Concrete
{
    public class ProductOperations
    {
        private readonly ProductDal _productDal;
        private readonly CategoryDal _categoryDal;

        public ProductOperations()
        {
            _productDal = new ProductDal();
            _categoryDal = new CategoryDal();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAllProducts();
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAllCategories().ToList();
        }

        public List<Product> SearchByCategory(int categoryId)
        {
            return _productDal.GetAllProducts().Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
