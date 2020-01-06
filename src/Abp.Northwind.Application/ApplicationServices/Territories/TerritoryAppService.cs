using Abp.Northwind.ApplicationServices.Territories.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Territories
{
    public class TerritoryAppService : CrudAppService<Territory,TerritoryDto, string, PagedAndSortedResultRequestDto, CreateTerritoryDto, UpdateTerritoryDto>, ITerritoryAppService
    {
        public TerritoryAppService(IRepository<Territory, string> repository) : base(repository)
        {
        }
    }
}