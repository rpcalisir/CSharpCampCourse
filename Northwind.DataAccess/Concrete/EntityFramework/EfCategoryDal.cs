using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : DbContext, ICategoryDal
    {
        private readonly NorthwindContext _context;
        public EfCategoryDal()
        {
            _context = new NorthwindContext();
        }
        public void AddToDb(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteInDb(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            using (_context)
            {
                return _context.Categories.ToList();
            }
        }

        public Category GetById(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateInDb(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
