using Abp.Northwind.ApplicationServices.EmployeeTerritories.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.EmployeeTerritories
{
    public interface IEmployeeTerritoryAppService: ICrudAppService<EmployeeTerritoryDto, object[], PagedAndSortedResultRequestDto, CreateEmployeeTerritoryDto,UpdateEmployeeTerritoryDto>
    {
        
    }
}