using Northwind.BusinessTwo.Interface;
using Northwind.DataAccessTwo.Concrete.EntityFramework;
using Northwind.DataAccessTwo.Interface;
using Northwind.EntitiesTwo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessTwo.Concrete.EntityFramework
{
    public class ProductManager : IManager
    {
        //private readonly IEntityDal<Product> _efProductDal;
        private readonly EfProductDal _efProductDal;

        //public ProductManager(IEntityDal<Product> entityDal)
        //{
        //    _efProductDal = new entitydal();
        //}
        public ProductManager()
        {
            _efProductDal = new EfProductDal();
        }
        public List<Product> ListAll()
        {
            return _efProductDal.GetAll();
        }
    }
}
