using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Interface
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProduct(int productId);
        void AddProduct(Product product);
        List<Category> GetAllCategories();
    }
}
