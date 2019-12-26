using Abp.Northwind.Entities;

namespace Abp.Northwind.DataSeeder
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Volo.Abp.Data;
    using Volo.Abp.DependencyInjection;
    using Volo.Abp.Domain.Repositories;

    namespace Abp.Northwind.DataSeeder
    {
        public class CategoriesSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
        {
            private readonly IRepository<Category, int> _repository;
            public CategoriesSeeder(IRepository<Category, int> repository) => _repository = repository;
            public async Task SeedAsync(DataSeedContext context)
            {
                if (await _repository.GetCountAsync() <= 0)
                {
                    foreach (var category in Categories.Values)
                    {
                        await _repository.InsertAsync(category);
                    }
                }
            }
        }
    }
}