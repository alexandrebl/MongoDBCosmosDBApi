using MongoDBCosmosDBApi.Domain.Base;

namespace MongoDBCosmosDBApi.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}