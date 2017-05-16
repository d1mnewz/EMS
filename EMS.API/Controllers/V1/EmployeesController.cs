using System;
using EMS.Core.Entities;
using EMS.Core.Repository.Employees;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{
    [Route("v1/Employees")]
    public class EmployeesV1ApiController : BaseAPIController<Employee, Guid>
    {
        private readonly IEmployeeRepository _repository;
        public EmployeesV1ApiController(IEmployeeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}