using MongoDB.Driver;

namespace MongoDBCosmosDBApi.Reposiory.Context
{
    public sealed class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IMongoClient GetClient()
        {
            return new MongoClient(_connectionString);
        }

        public IMongoDatabase GetDatabase(IMongoClient mongoClient, string databaseName)
        {
            return mongoClient.GetDatabase(databaseName);
        }

        public IMongoDatabase GetDatabase(string databaseName)
        {
            var mongoDbClient = GetClient();

            return mongoDbClient.GetDatabase(databaseName);
        }
    }
}