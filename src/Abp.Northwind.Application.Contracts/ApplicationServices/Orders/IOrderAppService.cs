using Abp.Northwind.ApplicationServices.Orders.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Orders
{
    public interface IOrderAppService: ICrudAppService<OrderDto, int, PagedAndSortedResultRequestDto, CreateOrderDto, UpdateOrderDto>
    {
        
    }
}