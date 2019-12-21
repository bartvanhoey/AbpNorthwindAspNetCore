using Abp.Northwind.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Northwind
{
    [DependsOn(
        typeof(NorthwindEntityFrameworkCoreTestModule)
        )]
    public class NorthwindDomainTestModule : AbpModule
    {

    }
}