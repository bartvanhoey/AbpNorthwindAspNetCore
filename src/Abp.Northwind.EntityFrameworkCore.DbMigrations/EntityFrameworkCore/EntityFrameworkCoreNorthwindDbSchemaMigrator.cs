using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Northwind.Data;
using Volo.Abp.DependencyInjection;

namespace Abp.Northwind.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreNorthwindDbSchemaMigrator 
        : INorthwindDbSchemaMigrator, ITransientDependency
    {
        private readonly NorthwindMigrationsDbContext _dbContext;

        public EntityFrameworkCoreNorthwindDbSchemaMigrator(NorthwindMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}