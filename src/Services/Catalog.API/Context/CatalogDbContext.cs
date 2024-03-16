using MongoRepo.Context;
using System.Configuration;

namespace Catalog.API.Context
{
    public class CatalogDbContext : ApplicationDbContext
    {
        private static IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
        private static string? connectionString = configuration.GetConnectionString("Catalog.API");
        private static string? databaseName = configuration.GetValue<string>("DatabaseName");

        public CatalogDbContext() : base(connectionString, databaseName)
        {
        }
    }
}
