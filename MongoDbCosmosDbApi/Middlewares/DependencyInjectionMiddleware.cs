using Microsoft.Extensions.DependencyInjection;
using MongoDBCosmosDBApi.Domain.Entities;
using MongoDBCosmosDBApi.Reposiory;
using MongoDBCosmosDBApi.Reposiory.Base;
using MongoDBCosmosDBApi.Reposiory.Interfaces;
using MongoDBCosmosDBApi.Services;
using MongoDBCosmosDBApi.Services.Interfaces;

namespace MongoDbCosmosDbApi.Middlewares
{
    public static class DependencyInjectionMiddleware
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<Product>, ProductRepository>();
            services.AddTransient<IProductServices, ProductServices>();
        }
    }
}