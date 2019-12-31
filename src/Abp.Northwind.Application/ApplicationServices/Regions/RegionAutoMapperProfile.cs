using Abp.Northwind.ApplicationServices.Regions.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Regions
{
    public class RegionAutoMapperProfile : Profile
    {
        public RegionAutoMapperProfile()
        {
            CreateMap<Region, RegionDto>();
            CreateMap<CreateRegionDto, Region>();
            CreateMap<UpdateRegionDto, Region>();
        }
    }
}