using MongoDBCosmosDBApi.Domain.Entities;
using System;
using System.Linq;

namespace MongoDBCosmosDBApi.Services.Interfaces
{
    public interface IProductServices
    {
        IQueryable<Product> QueryAll();

        Product Query(Guid key);
    }
}