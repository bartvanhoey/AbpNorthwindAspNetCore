using System.ComponentModel.DataAnnotations;

namespace Abp.Northwind.ApplicationServices.Categories.Dtos
{
    public class CreateCategoryDto
    {
        [Required] [StringLength(15)]  public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}