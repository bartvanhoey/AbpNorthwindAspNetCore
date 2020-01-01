using Abp.Northwind.ApplicationServices.Suppliers.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Suppliers
{
    public class SupplierAppService: CrudAppService<Supplier, SupplierDto, int, PagedAndSortedResultRequestDto, CreateSupplierDto, UpdateSupplierDto>, ISupplierAppService
    {
        public SupplierAppService(IRepository<Supplier, int> repository) : base(repository)
        {
        }
    }
}