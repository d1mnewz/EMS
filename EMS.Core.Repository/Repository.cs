using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EMS.Core.Data;
using EMS.Core.Data.Infrastructure;
using EMS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Core.Repository
{
    // TODO: implement other methods of repository
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        private readonly Context _context;
        protected DbSet<TEntity> Set => _context.Set<TEntity>();
        protected IQueryable<TEntity> Queryable => _context.Set<TEntity>().Where(x => !x.IsDeleted);
        protected IQueryable<TEntity> QueryableWithDeleted => _context.Set<TEntity>();

        public Repository(Context context)
        {
            _context = context;
        }

        public async Task<bool> AnyAsync(TId id)
        {
            var q = Queryable.Any(x => x.Id.Equals(id));
            Debug.WriteLine(q.ToString());
            return q;

        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public Task<TEntity> GetAsync(TId id)
        {
            return Queryable.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public virtual async Task<bool> InsertUpdateAsync(TEntity entity)
        {
            //if(entity invalid)
            //return false;
            //else
            await _context.Set<TEntity>().AddAsync(entity);
            //await _repository.SaveChangesAsync();
            return true;
        }

        public virtual async Task<bool> DeleteAsync(TId id)
        {
            var entity = await Queryable.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (entity != null)
            {
                entity.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IList<TEntity>> GetAsync(IFilter<TEntity, TId> filter)
        {
            var query = filter.Apply(Queryable);
            var orderedQuery = filter.Order(query);
            return await orderedQuery.ToListAsync();
        }
    }
}
