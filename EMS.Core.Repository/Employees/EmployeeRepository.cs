using System;
using EMS.Core.Data;
using EMS.Core.Entities;

namespace EMS.Core.Repository.Employees
{
    public class EmployeeRepository : Repository<Employee, Guid>, IEmployeeRepository
    {
        public EmployeeRepository(Context ctx) : base(ctx)
        {
        }
    }
}
