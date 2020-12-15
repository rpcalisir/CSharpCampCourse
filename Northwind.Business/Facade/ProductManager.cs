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
        private readonly ICategoryDal _categoryDal;

        public ProductManager()
        {
            _productDal = new EfProductDal();
            _categoryDal = new EfCategoryDal();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll().ToList();
        }

        public List<Product> SearchByCategory(int categoryId)
        {
            return _productDal.GetAll().Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
