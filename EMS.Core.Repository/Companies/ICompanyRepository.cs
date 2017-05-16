using System;
using EMS.Core.Data.Infrastructure;
using EMS.Core.Entities;

namespace EMS.Core.Repository.Companies
{
    public interface ICompanyRepository : IRepository<Company, Guid>
    {
    }
}