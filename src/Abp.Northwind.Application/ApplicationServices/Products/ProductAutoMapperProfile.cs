using Abp.Northwind.ApplicationServices.Products.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Products
{
    public class ProductAutoMapperProfile : Profile
    {
        public ProductAutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}