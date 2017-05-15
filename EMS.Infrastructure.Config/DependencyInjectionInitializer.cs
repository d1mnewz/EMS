using System;
using EMS.Infrastructure.DI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using StructureMap.AspNetCore;

namespace EMS.Infrastructure.Config
{
    public static class DependencyInjectionInitializer
    {
        public static IWebHostBuilder UseDependencyInjection(this IWebHostBuilder builder)
        {
            builder.UseStructureMap();
            return builder;
        }

        public static IServiceProvider PrepareServiceProviderDI(this IServiceCollection services)
        {
            var container = DIContainer.Prepare();
            container.Populate(services);
            return container.GetInstance<IServiceProvider>();
        }
    }
}