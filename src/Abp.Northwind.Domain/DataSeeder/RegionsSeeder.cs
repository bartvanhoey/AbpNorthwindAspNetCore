using System.Threading.Tasks;
using Abp.Northwind.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class RegionsSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Region, int> _repository;

        public RegionsSeeder(IRepository<Region, int> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                var regions = new[]
                {
                    new Region {Id = 1, RegionDescription = "Eastern"},
                    new Region {Id = 2, RegionDescription = "Western"},
                    new Region {Id = 3, RegionDescription = "Northern"},
                    new Region {Id = 4, RegionDescription = "Southern"}
                };

                foreach (var region in regions)
                {
                    await _repository.InsertAsync(region);
                }
            }
        }
    }
}