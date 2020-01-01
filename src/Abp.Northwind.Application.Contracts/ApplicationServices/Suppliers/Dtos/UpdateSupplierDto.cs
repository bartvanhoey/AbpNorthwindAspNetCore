using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.SupplierConsts;

namespace Abp.Northwind.ApplicationServices.Suppliers.Dtos
{
    public class UpdateSupplierDto
    {
        [Required]
        [StringLength(MaxLengthCompanyName)]
        public string CompanyName { get; set; }
        [StringLength(MaxLengthContactName)] public string ContactName { get; set; }
        [StringLength(MaxLengthContactTitle)] public string ContactTitle { get; set; }
        [StringLength(MaxLengthAddress)] public string Address { get; set; }
        [StringLength(MaxLengthCity)] public string City { get; set; }
        [StringLength(MaxLengthRegion)] public string Region { get; set; }
        [StringLength(MaxLengthPostalCode)] public string PostalCode { get; set; }
        [StringLength(MaxLengthCountry)] public string Country { get; set; }
        [StringLength(MaxLengthPhone)] public string Phone { get; set; }
        [StringLength(MaxLengthFax)] public string Fax { get; set; }
        public string HomePage { get; set; }
    }
}