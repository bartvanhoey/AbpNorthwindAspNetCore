using System.Threading.Tasks;
using Abp.Northwind.ApplicationServices.Orders.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Orders
{
    public class OrderAppService : CrudAppService<Order, OrderDto, int, PagedAndSortedResultRequestDto, CreateOrderDto, UpdateOrderDto>, IOrderAppService
    {
        public OrderAppService(IRepository<Order, int> repository) : base(repository)
        {
        }
    }
}