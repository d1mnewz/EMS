using System.Linq;
using EMS.Core.Entities;

namespace EMS.Core.Data.Infrastructure
{
    public interface IFilter<TEntity, TId> where TEntity : Entity<TId>
    {
        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
        IOrderedQueryable<TEntity> Order(IQueryable<TEntity> query);
    }

    public abstract class Filter<TEntity, TId> : IFilter<TEntity, TId> where TEntity : Entity<TId>
    {
        public virtual IQueryable<TEntity> Apply(IQueryable<TEntity> query)
        {
            return query;
        }

        public IOrderedQueryable<TEntity> Order(IQueryable<TEntity> query)
        {
            return query.OrderBy(x => x.Id);
        }
    }
}