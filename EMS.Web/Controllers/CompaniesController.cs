using System;
using EMS.Core.Data;
using EMS.Core.Entities;


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