using System;
using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.EmployeeConsts;

namespace Abp.Northwind.ApplicationServices.Employees.Dtos
{
    public class UpdateEmployeeDto
    {
        [StringLength(MaxLengthAddress)] public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        [StringLength(MaxLengthCity)] public string City { get; set; }
        [StringLength(MaxLengthCountry)] public string Country { get; set; }
        [StringLength(MaxLengthExtension)] public string Extension { get; set; }
        [Required] [StringLength(MaxLengthFirstName)] public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        [StringLength(MaxLengthHomePhone)] public string HomePhone { get; set; }
        [Required] [StringLength(MaxLengthLastName)] public string LastName { get; set; }
        public string Notes { get; set; }
        public byte[] Photo { get; set; }
        [StringLength(MaxLengthPhotoPath)] public string PhotoPath { get; set; }
        [StringLength(MaxLengthPostalCode)] public string PostalCode { get; set; }
        [StringLength(MaxLengthRegion)] public string Region { get; set; }
        public int? ReportsTo { get; set; }
        [StringLength(MaxLengthTitle)] public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        
    }
}