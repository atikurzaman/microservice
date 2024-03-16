using Catalog.API.Models;
using MongoRepo.Interfaces.Repository;

namespace Catalog.API.Interfaces.Repositories;

public interface IProductRepository:ICommonRepository<Product>
{
}
