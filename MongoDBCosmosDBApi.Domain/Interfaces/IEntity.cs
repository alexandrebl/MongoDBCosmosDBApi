using System;

namespace MongoDBCosmosDBApi.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Key { get; set; }
    }
}