using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Models;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class CustomersSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Customer, string> _repository;
        public CustomersSeeder(IRepository<Customer, string> repository) => _repository = repository;

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var customer in Customers)
                {
                    await _repository.InsertAsync(customer);
                }
            }
        }
    }
}