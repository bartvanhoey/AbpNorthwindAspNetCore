using Abp.Northwind.ApplicationServices.Employees.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Employees
{
    public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, int, PagedAndSortedResultRequestDto, CreateEmployeeDto, UpdateEmployeeDto>, IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, int> repository) : base(repository)
        {
        }
    }
}