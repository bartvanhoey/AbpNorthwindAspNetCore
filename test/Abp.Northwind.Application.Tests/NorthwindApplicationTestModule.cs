using Volo.Abp.Modularity;

namespace Abp.Northwind
{
    [DependsOn(
        typeof(NorthwindApplicationModule),
        typeof(NorthwindDomainTestModule)
        )]
    public class NorthwindApplicationTestModule : AbpModule
    {

    }
}