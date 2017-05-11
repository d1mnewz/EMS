using System;
using EMS.Core.Infrastructure.Db;
using EMS.Web.Core.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace EMS.Infrastructure.Config
{
    public static class DataInitializer
    {
        public static void AddDataSource(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));
        }

        public static void InitializeDataSource(this IApplicationBuilder builder)
        {
            var seeders = builder.ApplicationServices.GetService<IServiceProvider>().GetServices<ISeed>();
            foreach (var seeder in seeders)
            {
                seeder.Seed();
            }
        }
    }
}
