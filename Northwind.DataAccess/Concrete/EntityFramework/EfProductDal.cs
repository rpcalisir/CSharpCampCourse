using Northwind.DataAccess.Abstract.EntityFramework;
using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityDalBase<Product, NorthwindContext>, IProductDal
    {
        
    }
}
