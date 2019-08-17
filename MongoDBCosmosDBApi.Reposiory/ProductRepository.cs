using MongoDB.Driver;
using MongoDBCosmosDBApi.Domain.Entities;
using MongoDBCosmosDBApi.Reposiory.Base;
using MongoDBCosmosDBApi.Reposiory.Context;

namespace MongoDBCosmosDBApi.Reposiory
{
    public sealed class ProductRepository : Repository<Product>
    {
        public ProductRepository(IMongoCollection<Product> collectionName) : base(collectionName)
        {
        }

        public ProductRepository(IConnectionFactory connectionFactory, string databaseName, string collectionName)
            : base(connectionFactory, databaseName, collectionName)
        {
        }
    }
}