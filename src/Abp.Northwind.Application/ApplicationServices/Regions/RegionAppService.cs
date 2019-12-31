using Abp.Northwind.ApplicationServices.Regions.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Regions
{
    public class RegionAppService: CrudAppService<Region, RegionDto, int, PagedAndSortedResultRequestDto, CreateRegionDto, UpdateRegionDto>, IRegionAppService
    {
        public RegionAppService(IRepository<Region, int> repository) : base(repository)
        {
        }
    }
}