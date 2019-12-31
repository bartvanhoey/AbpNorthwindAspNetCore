using Abp.Northwind.ApplicationServices.Orders.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Orders
{
    public class OrderAutoMapperProfile : Profile
    {
        public OrderAutoMapperProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<CreateOrderDto, Order>();
            CreateMap<UpdateOrderDto, Order>();
        }
    }
}