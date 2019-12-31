using Abp.Northwind.ApplicationServices.Products.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Northwind.ApplicationServices.Products
{
    public interface IProductAppService : ICrudAppService<ProductDto, int, PagedAndSortedResultRequestDto,
        CreateProductDto, UpdateProductDto>
    {
    }
}