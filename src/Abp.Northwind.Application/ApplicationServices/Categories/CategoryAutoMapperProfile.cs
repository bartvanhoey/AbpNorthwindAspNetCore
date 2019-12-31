using Abp.Northwind.ApplicationServices.Categories.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Categories
{
    public class CategoryAutoMapperProfile : Profile
    {
        public CategoryAutoMapperProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
        }
    }
}