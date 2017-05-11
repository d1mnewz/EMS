using System;
using EMS.Core.Data;
using EMS.Core.Infrastructure.Db;
using EMS.Web.Core.Data;
using Faking;


namespace EMS.Core.Entities.Seed
{
    public class CompaniesSeed : ISeed
    {
        private readonly Context _context;

        public CompaniesSeed(Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Companies.Clear();
            var rnd = new Random();

            for (int i = 0; i < rnd.Next(420); i++)
            {
                var cmp = new Company
                {
                    Title = Faker.Default.Create<string>("lorem"),
                    IsDeleted = false
                };
                _context.Companies.Add(cmp);
            }
            _context.SaveChanges(true);
        }
    }
}