using Abp.Northwind.ApplicationServices.Products.Dtos;
using Abp.Northwind.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.ApplicationServices.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, int, PagedAndSortedResultRequestDto, CreateProductDto, UpdateProductDto> ,IProductAppService
    {
        public ProductAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}