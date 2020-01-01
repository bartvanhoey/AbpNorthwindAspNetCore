using Abp.Northwind.ApplicationServices.Shippers.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Shippers
{
    public class ShipperAutoMapperProfile : Profile
    {
        public ShipperAutoMapperProfile()
        {
            CreateMap<Shipper, ShipperDto>();
            CreateMap<CreateShipperDto, Shipper>();
            CreateMap<UpdateShipperDto, Shipper>();
        }
    }
}