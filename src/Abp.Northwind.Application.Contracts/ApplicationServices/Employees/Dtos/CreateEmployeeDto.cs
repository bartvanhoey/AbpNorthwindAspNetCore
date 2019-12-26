using System;
using System.ComponentModel.DataAnnotations;

namespace Abp.Northwind.ApplicationServices.Employees.Dtos
{
    public class CreateEmployeeDto
    {
        [StringLength(60)] public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        [StringLength(15)] public string City { get; set; }
        [StringLength(15)] public string Country { get; set; }
        [StringLength(4)] public string Extension { get; set; }
        [Required] [StringLength(10)] public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        [StringLength(24)] public string HomePhone { get; set; }
        [Required] [StringLength(20)] public string LastName { get; set; }
        public string Notes { get; set; }
        public byte[] Photo { get; set; }
        [StringLength(255)] public string PhotoPath { get; set; }
        [StringLength(10)] public string PostalCode { get; set; }
        [StringLength(15)] public string Region { get; set; }
        public int? ReportsTo { get; set; }
        [StringLength(30)] public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string UserId { get; set; }
    }
}