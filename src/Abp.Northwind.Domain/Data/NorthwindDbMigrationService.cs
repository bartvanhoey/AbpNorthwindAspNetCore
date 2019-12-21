using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Abp.Northwind.Data
{
    public class NorthwindDbMigrationService : ITransientDependency
    {
        public ILogger<NorthwindDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly INorthwindDbSchemaMigrator _dbSchemaMigrator;

        public NorthwindDbMigrationService(
            IDataSeeder dataSeeder,
            INorthwindDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<NorthwindDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}