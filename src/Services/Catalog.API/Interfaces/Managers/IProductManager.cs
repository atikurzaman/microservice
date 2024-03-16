using Catalog.API.Models;
using MongoRepo.Interfaces.Manager;

namespace Catalog.API.Interfaces.Managers;

public interface IProductManager:ICommonManager<Product>
{
    List<Product> GetByCategory(string category);
}
