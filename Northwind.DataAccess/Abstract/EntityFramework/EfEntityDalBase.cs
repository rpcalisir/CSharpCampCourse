using Northwind.DataAccess.Interface;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract.EntityFramework
{
    public abstract class EfEntityDalBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void AddToDb(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteInDb(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntry = context.Entry(entity);
                deletedEntry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateInDb(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntry = context.Entry(entity);
                updatedEntry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
