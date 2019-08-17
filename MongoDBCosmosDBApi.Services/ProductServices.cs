using MongoDBCosmosDBApi.Domain.Entities;
using MongoDBCosmosDBApi.Reposiory.Interfaces;
using MongoDBCosmosDBApi.Services.Interfaces;
using System;
using System.Linq;

namespace MongoDBCosmosDBApi.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IRepository<Product> _productRepository;

        public ProductServices(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IQueryable<Product> QueryAll()
        {
            var result = _productRepository.QueryAll();

            return result;
        }

        public Product Query(Guid key)
        {
            var result = _productRepository.Query(key);

            return result;
        }
    }
}