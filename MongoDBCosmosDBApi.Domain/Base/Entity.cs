using System;
using MongoDBCosmosDBApi.Domain.Interfaces;

namespace MongoDBCosmosDBApi.Domain.Base
{
    public abstract class Entity : IEntity
    {
        public Guid Key { get; set; }

        protected Entity()
        {
            this.Key = Guid.NewGuid();
        }
    }
}