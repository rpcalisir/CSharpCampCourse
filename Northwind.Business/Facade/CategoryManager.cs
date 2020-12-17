using Northwind.Business.Interface;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Facade
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal _efCategoryDal;
        public CategoryManager()
        {
            _efCategoryDal = new EfCategoryDal();
        }
        public List<Category> GetAllCategories()
        {
            return _efCategoryDal.GetAll();
        }
    }
}
