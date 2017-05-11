using System;
using System.Collections.Generic;

namespace EMS.Core.Entities
{
    public class Company : Entity
    {

        public string Title { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }


}