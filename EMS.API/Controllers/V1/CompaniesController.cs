using System;
using EMS.Core.Entities;
using EMS.Core.Repository.Companies;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers.V1
{
    [Route("v1/Companies")]
    public class CompaniesController : BaseAPIController<Company, Guid>
    {
        private readonly ICompanyRepository _repository;
        public CompaniesController(ICompanyRepository repository) : base(repository) => _repository = repository;
    }
}