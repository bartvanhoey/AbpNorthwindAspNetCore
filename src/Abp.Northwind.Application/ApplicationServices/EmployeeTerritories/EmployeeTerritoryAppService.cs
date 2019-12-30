using System.Threading.Tasks;
using Abp.Northwind.ApplicationServices.EmployeeTerritories.Dtos;
using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.EmployeeTerritories
{
    public class EmployeeTerritoryAppService : IEmployeeTerritoryAppService
    {
        public Task<EmployeeTerritoryDto> GetAsync(object[] id)
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public Task<PagedResultDto<EmployeeTerritoryDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public Task<EmployeeTerritoryDto> CreateAsync(CreateEmployeeTerritoryDto input)
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public Task<EmployeeTerritoryDto> UpdateAsync(object[] id, UpdateEmployeeTerritoryDto input)
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(object[] id)
        {
            // TODO
            throw new System.NotImplementedException();
        }
    }
}