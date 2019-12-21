using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Northwind.Data
{
    /* This is used if database provider does't define
     * INorthwindDbSchemaMigrator implementation.
     */
    public class NullNorthwindDbSchemaMigrator : INorthwindDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}