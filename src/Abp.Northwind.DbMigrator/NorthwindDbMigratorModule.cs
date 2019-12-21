using Abp.Northwind.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.Northwind.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(NorthwindEntityFrameworkCoreDbMigrationsModule),
        typeof(NorthwindApplicationContractsModule)
        )]
    public class NorthwindDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
