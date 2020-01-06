using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.TerritoryConsts;

namespace Abp.Northwind.ApplicationServices.Territories.Dtos
{
    public class CreateTerritoryDto
    {
        [Required] [StringLength(MaxLengthTerritoryId)]
        public string Id { get; set; }
        [Required] [StringLength(MaxLengthTerritoryDescription)]
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
    }
}