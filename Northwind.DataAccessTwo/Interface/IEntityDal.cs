using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessTwo.Interface
{
    public interface IEntityDal<TEntity>
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void AddToDb(TEntity entity);
        void DeletInDb(TEntity entity);
        void UpdateInDb(TEntity entity);
    }
}
