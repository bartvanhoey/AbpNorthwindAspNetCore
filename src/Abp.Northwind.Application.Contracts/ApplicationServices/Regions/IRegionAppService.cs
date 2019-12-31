using Abp.Northwind.ApplicationServices.Regions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Regions
{
    public interface IRegionAppService : ICrudAppService<RegionDto, int, PagedAndSortedResultRequestDto,
        CreateRegionDto, UpdateRegionDto>
    {
    }
}