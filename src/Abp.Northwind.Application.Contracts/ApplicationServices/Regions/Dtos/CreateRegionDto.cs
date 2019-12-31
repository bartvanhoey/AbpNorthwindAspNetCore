using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.RegionConsts;

namespace Abp.Northwind.ApplicationServices.Regions.Dtos
{
    public class CreateRegionDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(MaxLengthRegionDescription)]
        public string RegionDescription { get; set; }
    }
}