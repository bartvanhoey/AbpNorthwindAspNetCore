using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class ProductsSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, int> _repository;

        public ProductsSeeder(IRepository<Product, int> repository) => _repository = repository;

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var product in Products.Values)
                {
                    await _repository.InsertAsync(product);
                }
            }
        }
    }
}