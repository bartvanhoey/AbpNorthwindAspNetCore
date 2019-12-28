using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.CategoryConsts;

namespace Abp.Northwind.ApplicationServices.Categories.Dtos
{
    public class UpdateCategoryDto
    {
        [Required] [StringLength(MaxLengthCategoryName)]  public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}