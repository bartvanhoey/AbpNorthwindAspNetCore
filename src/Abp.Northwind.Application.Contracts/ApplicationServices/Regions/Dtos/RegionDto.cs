using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.Regions.Dtos
{
    public class RegionDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public string RegionDescription { get; set; }
    }
}