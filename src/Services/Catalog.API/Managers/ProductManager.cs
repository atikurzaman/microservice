using Catalog.API.Interfaces.Managers;
using Catalog.API.Models;
using Catalog.API.Repositories;
using MongoRepo.Manager;

namespace Catalog.API.Managers;

public class ProductManager : CommonManager<Product>, IProductManager
{
    public ProductManager() : base(new ProductRepository())
    {
    }

    public List<Product> GetByCategory(string category)
    {
        return GetAll(p=>p.Category == category).ToList();
    }
}
