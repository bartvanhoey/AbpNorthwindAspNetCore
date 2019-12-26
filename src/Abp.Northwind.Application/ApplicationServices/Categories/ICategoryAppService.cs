using Abp.Northwind.ApplicationServices.Categories.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Categories
{
    public interface ICategoryAppService: ICrudAppService<CategoryDto, int, PagedAndSortedResultRequestDto, CreateCategoryDto,UpdateCategoryDto>
    {
        
    }
}