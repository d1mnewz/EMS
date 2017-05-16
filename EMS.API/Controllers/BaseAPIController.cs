using System.Collections.Generic;
using System.Threading.Tasks;
using EMS.Core.Data.Infrastructure;
using EMS.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{

    // TODO: Implement other API methods
    // TODO: Code refactoring
    public abstract class BaseAPIController<TEntity, TId> : Controller where TEntity : Entity<TId>
    {
        protected readonly IRepository<TEntity, TId> Repository;

        public BaseAPIController(IRepository<TEntity, TId> repository)
        {
            Repository = repository;
        }

        // GET: api/Base
        [HttpGet]
        public Task<IList<TEntity>> Get()
        {
            return Repository.GetAll();
        }

        // GET: api/Base/5
        [HttpGet("{id}")]
        public Task<TEntity> Get(TId id)
        {
            return Repository.GetAsync(id);
        }

        // POST: api/Base
        [HttpPost]
        public void Post([FromBody] TEntity value)
        {
            //TODO
        }

        // PUT: api/Base/5
        [HttpPut("{id}")]
        public void Put(TId id, [FromBody] TEntity value)
        {
            //TODO
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(TId id)
        {
            //TODO
        }
    }
}