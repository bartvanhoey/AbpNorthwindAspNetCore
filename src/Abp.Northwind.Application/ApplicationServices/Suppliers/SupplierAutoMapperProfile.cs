using Abp.Northwind.ApplicationServices.Suppliers.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Suppliers
{
    public class SupplierAutoMapperProfile : Profile
    {
        public SupplierAutoMapperProfile()
        {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>();
            CreateMap<UpdateSupplierDto, Supplier>();
        }
    }
}