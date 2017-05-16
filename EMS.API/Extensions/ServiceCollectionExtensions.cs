using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace EMS.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDocumentationGeneration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "EmployeeManagementSystem API",
                    Description = "Simple web app with open API for Euristiq needs",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Euristiq", Email = "", Url = @"http://www.euristiq.com/" }
                });
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "EMS.API.xml");
                c.IncludeXmlComments(xmlPath);
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder app)
        {
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            return app;
        }
    }
}
