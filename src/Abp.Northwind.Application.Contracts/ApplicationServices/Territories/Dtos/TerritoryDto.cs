using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.Territories.Dtos
{
    public class TerritoryDto: AuditedEntityDto<string>
    {
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
    }
}