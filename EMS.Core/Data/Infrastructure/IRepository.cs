using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Core.Entities;

namespace EMS.Core.Data.Infrastructure
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        Task<bool> AnyAsync(TId id);
        Task<TEntity> GetAsync(TId id);
        Task<IList<TEntity>> GetAll();
        Task<bool> InsertUpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TId id);
        Task<IList<TEntity>> GetAsync(IFilter<TEntity, TId> filter);
    }

}
