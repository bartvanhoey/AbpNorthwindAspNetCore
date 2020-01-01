using Abp.Northwind.ApplicationServices.Suppliers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Suppliers
{
    public interface ISupplierAppService : ICrudAppService<SupplierDto, int, PagedAndSortedResultRequestDto,
        CreateSupplierDto, UpdateSupplierDto>
    {
    }
}