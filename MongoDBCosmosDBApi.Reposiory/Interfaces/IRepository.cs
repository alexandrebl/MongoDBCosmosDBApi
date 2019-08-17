using System;
using System.Linq;
using MongoDBCosmosDBApi.Domain.Entities;

namespace MongoDBCosmosDBApi.Reposiory.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> QueryAll();

        T Query(Guid key);
        void Insert(T obj);
    }
}