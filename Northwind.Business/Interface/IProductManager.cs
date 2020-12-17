using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Interface
{
    public interface IProductManager
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByName(string productName);
    }
}
