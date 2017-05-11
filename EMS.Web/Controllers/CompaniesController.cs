using System;
using EMS.Core.Entities;
using EMS.Web.Core.Data;

namespace EMS.Web.Controllers
{
    public class CompaniesController : BaseController<Company, Guid>
    {
        private readonly Context _context;

        public CompaniesController(Context context) : base(context)
        {
            _context = context;
        }
    }
}