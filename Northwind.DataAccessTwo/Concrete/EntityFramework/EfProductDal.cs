using Northwind.DataAccessTwo.Abstract.EntityFramework;
using Northwind.DataAccessTwo.Interface;
using Northwind.EntitiesTwo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessTwo.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityDalBase<Product, NorthwindContext>, IProductDal
    {
       
    }
}
