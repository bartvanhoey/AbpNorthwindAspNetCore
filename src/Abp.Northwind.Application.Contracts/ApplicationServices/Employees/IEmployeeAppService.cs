using Abp.Northwind.ApplicationServices.Employees.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Employees
{
    public interface IEmployeeAppService : ICrudAppService<EmployeeDto, int, PagedAndSortedResultRequestDto,
        CreateEmployeeDto, UpdateEmployeeDto>

    {
    }
}