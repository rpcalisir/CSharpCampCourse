using Northwind.DataAccess.Abstract.EntityFramework;
using Northwind.DataAccess.Interface;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityDalBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
