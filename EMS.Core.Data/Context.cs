using EMS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Web.Core.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}