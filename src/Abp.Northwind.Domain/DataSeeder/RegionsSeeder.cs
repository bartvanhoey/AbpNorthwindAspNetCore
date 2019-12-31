using System.Threading.Tasks;
using Abp.Northwind.Models;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class RegionsSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Region, int> _repository;

        public RegionsSeeder(IRepository<Region, int> repository) => _repository = repository;

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var region in Regions)
                {
                    await _repository.InsertAsync(region);
                }
            }
        }
    }
}