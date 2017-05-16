using System;
using EMS.Core.Data;
using EMS.Core.Entities;

namespace EMS.Core.Repository.Companies
{
    public class CompanyRepository : Repository<Company, Guid>, ICompanyRepository
    {
        public CompanyRepository(Context ctx) : base(ctx)
        {
        }
    }
}
