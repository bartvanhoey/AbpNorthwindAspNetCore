using Abp.Northwind.ApplicationServices.Employees.Dtos;
using Abp.Northwind.Models;
using AutoMapper;

namespace Abp.Northwind.ApplicationServices.Employees
{
    public class EmployeeAutoMapperProfile : Profile
    {
        public EmployeeAutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();
        }
    }
}