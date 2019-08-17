using System;
using System.Linq;

namespace MongoDBCosmosDBApi.Reposiory.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> QueryAll();

        T Query(Guid key);
    }
}