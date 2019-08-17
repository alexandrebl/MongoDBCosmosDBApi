using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDBCosmosDBApi.Domain.Entities;
using MongoDBCosmosDBApi.Services.Interfaces;

namespace MongoDbCosmosDbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductServices productServices, ILogger<ProductController> logger)
        {
            _productServices = productServices;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            try
            {
                var result = _productServices.QueryAll();

                return Ok(result.ToList());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{key}")]
        public ActionResult<Product> Get([FromRoute] Guid key)
        {
            try
            {
                var result = _productServices.Query(key);

                return Ok(result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message, key);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<Product> Insert([FromBody] Product product)
        {
            try
            {

                _productServices.Insert(product);

            return Ok();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message, product);
                return new StatusCodeResult(500);
            }
        }
    }
}