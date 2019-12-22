using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class SuppliersSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Supplier, int> _repository;

        public SuppliersSeeder(IRepository<Supplier, int> repository) => _repository = repository;

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var supplier in Suppliers.Values)
                {
                    await _repository.InsertAsync(supplier);
                }
            }
        }
    }
}