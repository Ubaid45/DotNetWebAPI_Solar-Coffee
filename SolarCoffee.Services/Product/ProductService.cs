using System.Collections.Generic;
using System.Linq;
using SolarCoffee.Data;

namespace SolarCoffee.Services.Product
{
    public class ProductService : IProductService {

        private readonly SolarDbContext _db;

        public ProductService(SolarDbContext dbContext) {
            _db = dbContext;
        }
        
        /// <summary>
        /// Retrieves all Product from the database
        /// </summary>
        /// <returns></returns>
        public List<Data.Models.Product> GetAllProducts() {
            return _db.Products.ToList();
        }
        
    }
}