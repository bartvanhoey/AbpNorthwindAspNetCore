using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.Categories.Dtos
{
    public class CategoryDto : AuditedEntityDto<int>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}