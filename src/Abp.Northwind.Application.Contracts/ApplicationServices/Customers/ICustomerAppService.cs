using Abp.Northwind.ApplicationServices.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Customers
{
    public interface ICustomerAppService : ICrudAppService<CustomerDto, string, PagedAndSortedResultRequestDto,
        CreateCustomerDto, UpdateCustomerDto>
    {
    }
}