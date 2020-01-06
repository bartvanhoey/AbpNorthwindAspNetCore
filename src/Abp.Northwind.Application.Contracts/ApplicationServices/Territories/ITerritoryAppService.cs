using Abp.Northwind.ApplicationServices.Territories.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Territories
{
    public interface ITerritoryAppService : ICrudAppService<TerritoryDto, string, PagedAndSortedResultRequestDto,
        CreateTerritoryDto, UpdateTerritoryDto>
    {
    }
}