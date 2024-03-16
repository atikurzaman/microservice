using Catalog.API.Context;
using Catalog.API.Interfaces.Repositories;
using Catalog.API.Models;
using MongoRepo.Repository;

namespace Catalog.API.Repositories;

public class ProductRepository : CommonRepository<Product>, IProductRepository
{
    public ProductRepository() : base(new CatalogDbContext())
    {
    }
}
