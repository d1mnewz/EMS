using System;
using EMS.Core.Data.Infrastructure;

namespace EMS.Core.Repository.Employees
{
    public interface IEmployeeRepository : IRepository<Entities.Employee, Guid>
    {
    }

}
