using System.Threading.Tasks;
using EMS.Core.Entities;
using EMS.Web.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMS.Web.Controllers
{
    public abstract class BaseController<TEntity, TId> : Controller where TEntity : Entity<TId>
    {
        protected readonly Context Context;

        public BaseController(Context context)
        {
            Context = context;
        }

        // GET: TEntities/Index
        public virtual async Task<IActionResult> Index()
        {
            return View(await Context.Set<TEntity>().ToListAsync());
        }

        // GET: TEntities/Details/5
        public virtual async Task<IActionResult> Details(TId id)
        {
            var company = await Context.Set<TEntity>().SingleOrDefaultAsync(m => m.Id.Equals(id));
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: TEntities/Create
        public virtual IActionResult Create()
        {
            return View();
        }

        // POST: TEntities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TEntity entity)
        {
            if (ModelState.IsValid)
            {
                Context.Add(entity);
                await Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(entity);
        }

        // GET: TEntities/Edit/5
        public async Task<IActionResult> Edit(TId id)
        {
            var company = await Context.Set<TEntity>().SingleOrDefaultAsync(m => m.Id.Equals(id));
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: TEntities/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TId id, TEntity entity)
        {
            if (!id.Equals(entity.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Context.Update(entity);
                    await Context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntityExists(entity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        // GET: TEntities/Delete/5
        public async Task<IActionResult> Delete(TId id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await Context.Companies
                .SingleOrDefaultAsync(m => m.Id.Equals(id));
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: TEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(TId id)
        {
            var company = await Context.Companies.SingleOrDefaultAsync(m => m.Id.Equals(id));
            Context.Companies.Remove(company);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        private bool EntityExists(TId id)
        {
            return Context.Set<TEntity>().Any(e => e.Id.Equals(id));
        }
    }
}