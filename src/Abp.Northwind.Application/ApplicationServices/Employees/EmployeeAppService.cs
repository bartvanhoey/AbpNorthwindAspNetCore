using Abp.Northwind.ApplicationServices.Employees.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Abp.Northwind.Entities;

namespace Abp.Northwind.ApplicationServices.Employees
{
    public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, int, PagedAndSortedResultRequestDto, CreateEmployeeDto, UpdateEmployeeDto>, IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, int> repository) : base(repository)
        {
        }
    }
}