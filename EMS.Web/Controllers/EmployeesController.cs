using System;
using EMS.Core.Data;
using EMS.Core.Entities;

namespace EMS.Web.Controllers
{
    public class EmployeesController : BaseController<Employee, Guid>
    {
        private readonly Context _context;

        public EmployeesController(Context context) : base(context)
        {
            _context = context;
        }
    }
}