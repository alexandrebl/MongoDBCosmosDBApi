using MongoDBCosmosDBApi.Domain.Interfaces;
using System;

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