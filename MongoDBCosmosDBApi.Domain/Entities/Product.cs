using MongoDB.Bson.Serialization.Attributes;
using MongoDBCosmosDBApi.Domain.Base;

namespace MongoDBCosmosDBApi.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public sealed class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}