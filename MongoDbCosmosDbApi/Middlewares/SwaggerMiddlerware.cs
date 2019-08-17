using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace MongoDbCosmosDbApi.Middlewares
{
    public static class SwaggerMiddlerware
    {
        public static void AddSwaggerService(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "MongoDbCosmosDbApi",
                        Version = "v1",
                        Description = "MongoDb CosmosDb Api",
                        Contact = new Contact
                        {
                            Name = "Alexandre Brandão Lustosa",
                            Url = "https://github.com/alexandrebl/MongoDbCosmosDbApi"
                        }
                    });

                var caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"MongoDbCosmosDbApi.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }

        public static void UseSwaggerApp(this IApplicationBuilder app, string routePrefix)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "MongoDb CosmosDb Api");

                c.RoutePrefix = routePrefix;
            });
        }
    }
}