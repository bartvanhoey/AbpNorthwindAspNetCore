using System.Linq;
using System.Threading.Tasks;
using Abp.Northwind.Models;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Abp.Northwind.EntityFrameworkCore.Categories
{
    public class CategoryRepositoryTests : NorthwindEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Category, int> _categoryRepository;

        // ReSharper disable once VirtualMemberCallInConstructor
        public CategoryRepositoryTests() => _categoryRepository = GetRequiredService<IRepository<Category, int>>();

        [Fact]
        public async Task MethodName_Condition_ExpectedResult()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                //Act
                var beverages = await _categoryRepository
                    .Where(c => c.CategoryName == "Beverages").FirstOrDefaultAsync();

                //Assert
                beverages.ShouldNotBeNull();
            });
        }
    }
}