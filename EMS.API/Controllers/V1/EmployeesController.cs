using System;
using EMS.Core.Entities;
using EMS.Core.Repository.Employees;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers.V1
{
    [Route("v1/Employees")]
    public class EmployeesController : BaseAPIController<Employee, Guid>
    {
        private readonly IEmployeeRepository _repository;
        public EmployeesController(IEmployeeRepository repository) : base(repository) => _repository = repository;
    }
}