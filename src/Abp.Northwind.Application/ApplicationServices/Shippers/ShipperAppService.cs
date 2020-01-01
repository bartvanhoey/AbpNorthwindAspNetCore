using Abp.Northwind.ApplicationServices.Shippers.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Shippers
{
    public class ShipperAppService: CrudAppService<Shipper, ShipperDto, int, PagedAndSortedResultRequestDto, CreateShipperDto, UpdateShipperDto>, IShipperAppService
    {
        public ShipperAppService(IRepository<Shipper, int> repository) : base(repository)
        {
        }
    }
}