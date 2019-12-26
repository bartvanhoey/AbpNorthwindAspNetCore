using Abp.Northwind.ApplicationServices.Categories.Dtos;
using Abp.Northwind.ApplicationServices.Employees.Dtos;
using Abp.Northwind.Entities;
using AutoMapper;

namespace Abp.Northwind
{
    public class NorthwindApplicationAutoMapperProfile : Profile
    {
        public NorthwindApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
        }
    }
}
