using System;
using System.Collections.Generic;
using System.Linq;
using EMS.Web.Core.Data;
using Faking;
using EMS.Core.Extensions;
using EMS.Core.Infrastructure.Db;

namespace EMS.Core.Entities.Seed
{
    public class EmployeeSeed : ISeed
    {
        private readonly Context _context;

        public EmployeeSeed(Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Employees.Clear();
            var rnd = new Random();
            var employees = new List<Employee>();

            for (int i = 0; i < rnd.Next(420); i++)
            {
                var emp = new Employee
                {
                    Company = _context.Companies.ToArray().RandomElement(),
                    FirstName = Constants.Firstnames.RandomElement(),
                    LastName = Constants.Lastnames.RandomElement(),
                    Position = Faker.Default.Create<string>("job"),
                    Salary = Faker.Default.Create<int>(),
                    IsDeleted = false
                };
                employees.Add(emp);
            }
            _context.AddRange(employees);
            _context.SaveChanges(true);

        }
    }
}
