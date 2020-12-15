using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Interface
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        T GetById(int entityId);
        void AddToDb(T entity);
        void UpdateInDb(T entity);
        void DeleteInDb(T entity);
    }
}
