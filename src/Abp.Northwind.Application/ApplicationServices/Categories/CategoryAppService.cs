using Abp.Northwind.ApplicationServices.Categories.Dtos;
using Abp.Northwind.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Categories
{
    public class CategoryAppService : CrudAppService<Category, CategoryDto, int, PagedAndSortedResultRequestDto, CreateCategoryDto, UpdateCategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }
    }
}