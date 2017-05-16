namespace EMS.Core.Entities
{
    public class Employee : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public string Position { get; set; }

        public Company Company { get; set; }
    }
}