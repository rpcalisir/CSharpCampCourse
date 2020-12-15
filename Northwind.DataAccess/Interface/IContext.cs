using Northwind.Entities.Concrete;
using System;
using System.Data.Entity;

namespace Northwind.DataAccess.Interface
{
    public interface IContext : IDisposable
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
    }
}
