using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Models;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class ShippersSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Shipper, int> _repository;

        public ShippersSeeder(IRepository<Shipper, int> repository) => _repository = repository;

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var shipper in Shippers.Values)
                {
                    await _repository.InsertAsync(shipper);
                }
            }
        }
    }
}