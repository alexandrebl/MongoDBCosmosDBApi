using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDBCosmosDBApi.Domain.Entities;
using MongoDBCosmosDBApi.Domain.Settings;
using MongoDBCosmosDBApi.Reposiory;
using MongoDBCosmosDBApi.Reposiory.Base;
using MongoDBCosmosDBApi.Reposiory.Context;
using MongoDBCosmosDBApi.Reposiory.Interfaces;
using MongoDBCosmosDBApi.Services;
using MongoDBCosmosDBApi.Services.Interfaces;

namespace MongoDbCosmosDbApi.Middlewares
{
    public static class DependencyInjectionMiddleware
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoDbSettings = configuration.GetSection("MongoDBSetting").Get<MongoDBSetting>();

            var connectionFactory = new ConnectionFactory(mongoDbSettings.ConnectionString);

            services.AddSingleton<IRepository<Product>>(
                p => new ProductRepository(connectionFactory, mongoDbSettings.DatabaseName,
                    mongoDbSettings.CollectionName));
            services.AddTransient<IProductServices, ProductServices>();
        }
    }
}