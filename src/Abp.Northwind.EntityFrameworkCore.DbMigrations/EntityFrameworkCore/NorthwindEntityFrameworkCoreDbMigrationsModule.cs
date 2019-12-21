using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abp.Northwind.EntityFrameworkCore
{
    [DependsOn(
        typeof(NorthwindEntityFrameworkCoreModule)
        )]
    public class NorthwindEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NorthwindMigrationsDbContext>();
        }
    }
}
