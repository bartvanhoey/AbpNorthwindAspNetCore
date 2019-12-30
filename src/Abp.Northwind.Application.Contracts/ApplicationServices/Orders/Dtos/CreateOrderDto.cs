using System;
using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.OrderConsts;

namespace Abp.Northwind.ApplicationServices.Orders.Dtos
{
    public class CreateOrderDto
    {
        [StringLength(MaxLengthCustomerId)] public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        [StringLength(MaxLengthShipAddress)] public string ShipAddress { get; set; }
        [StringLength(MaxLengthShipCity)] public string ShipCity { get; set; }
        [StringLength(MaxLengthShipRegion)] public string ShipRegion { get; set; }

        [StringLength(MaxLengthShipPostalCode)]
        public string ShipPostalCode { get; set; }

        [StringLength(MaxLengthShipCountry)] public string ShipCountry { get; set; }
    }
}