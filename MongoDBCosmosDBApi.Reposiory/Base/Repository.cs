using MongoDB.Driver;
using MongoDBCosmosDBApi.Domain.Interfaces;
using MongoDBCosmosDBApi.Reposiory.Context;
using MongoDBCosmosDBApi.Reposiory.Interfaces;
using System;
using System.Linq;

namespace MongoDBCosmosDBApi.Reposiory.Base
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _collectionName;

        protected Repository(IMongoCollection<T> collectionName)
        {
            _collectionName = collectionName;
        }

        protected Repository(IConnectionFactory connectionFactory, string databaseName, string collectionName)
        {
            _collectionName = connectionFactory.GetDatabase(databaseName).GetCollection<T>(collectionName);
        }

        public IQueryable<T> QueryAll()
        {
            return _collectionName.AsQueryable<T>();
        }

        public T Query(Guid key)
        {
            return _collectionName.AsQueryable<T>().FirstOrDefault(w => w.Key == key);
        }
    }
}