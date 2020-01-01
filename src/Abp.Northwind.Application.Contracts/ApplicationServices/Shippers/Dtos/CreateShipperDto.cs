using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.ShipperConsts;

namespace Abp.Northwind.ApplicationServices.Shippers.Dtos
{
    public class CreateShipperDto
    {
        [Required]
        [StringLength(MaxLengthCompanyName)]
        public string CompanyName { get; set; }
        [StringLength(MaxLengthPhone)]
        public string Phone { get; set; }
    }
}