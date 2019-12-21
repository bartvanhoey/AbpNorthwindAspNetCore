using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.Northwind.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(NorthwindHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class NorthwindConsoleApiClientModule : AbpModule
    {
        
    }
}
