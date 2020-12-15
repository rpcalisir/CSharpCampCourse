using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.DataAccess.Concrete
{
    public class CategoryDal
    {
        public List<Category> GetAllCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
