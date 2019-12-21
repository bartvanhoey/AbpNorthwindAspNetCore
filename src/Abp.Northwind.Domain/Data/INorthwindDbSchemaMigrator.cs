using System.Threading.Tasks;

namespace Abp.Northwind.Data
{
    public interface INorthwindDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
