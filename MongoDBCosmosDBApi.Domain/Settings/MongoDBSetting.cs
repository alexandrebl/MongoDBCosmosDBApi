using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBCosmosDBApi.Domain.Settings
{
    public sealed class MongoDBSetting
    {
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
    }
}
