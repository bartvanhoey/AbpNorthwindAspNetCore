using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.Regions.Dtos
{
    public class RegionDto : AuditedEntityDto<int>
    {
        public string RegionDescription { get; set; }
    }
}