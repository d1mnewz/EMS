using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMS.Core.Entities;
using EMS.Web.Core.Data;

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
