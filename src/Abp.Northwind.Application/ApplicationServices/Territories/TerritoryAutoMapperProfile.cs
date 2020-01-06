using Abp.Northwind.ApplicationServices.Territories.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Territories
{
    public class TerritoryAutoMapperProfile : Profile
    {
        public TerritoryAutoMapperProfile()
        {
            CreateMap<Territory, TerritoryDto>();
            CreateMap<CreateTerritoryDto, Territory>();
            CreateMap<UpdateTerritoryDto, Territory>();
        }
    }
}