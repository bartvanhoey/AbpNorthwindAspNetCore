using Abp.Northwind.ApplicationServices.Shippers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Shippers
{
    public interface IShipperAppService : ICrudAppService<ShipperDto, int, PagedAndSortedResultRequestDto,
        CreateShipperDto, UpdateShipperDto>
    {
    }
}