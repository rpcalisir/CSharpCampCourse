using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : DbContext, IProductDal
    {
        private NorthwindContext _context;

        public EfProductDal()
        {
            _context = new NorthwindContext();
        }
        public List<Product> GetAll()
        {
            return FetchProducts().ToList();
        }
        public Product GetById(int productId)
        {
            return FetchProducts().Where(p => p.ProductId == productId).FirstOrDefault();
        }
        private List<Product> FetchProducts()
        {
            using (_context = new NorthwindContext())
            {
                return _context.Products.ToList();
            }
        }
        public void UpdateInDb(Product product)
        {
            throw new System.NotImplementedException();
        }
        public void DeleteInDb(Product product)
        {
            throw new System.NotImplementedException();
        }
        public void AddToDb(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
