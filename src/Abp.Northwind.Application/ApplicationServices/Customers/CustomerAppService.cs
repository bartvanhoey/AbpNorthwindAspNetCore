using Abp.Northwind.ApplicationServices.Customers.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Customers
{
    public class CustomerAppService : CrudAppService<Customer,CustomerDto, string, PagedAndSortedResultRequestDto, CreateCustomerDto, UpdateCustomerDto>, ICustomerAppService
    {
        public CustomerAppService(IRepository<Customer, string> repository) : base(repository)
        {
        }
    }
}