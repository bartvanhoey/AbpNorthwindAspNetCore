using System.ComponentModel.DataAnnotations;
using static Abp.Northwind.NorthwindSharedDomainConstants.ProductConsts;

namespace Abp.Northwind.ApplicationServices.Products.Dtos
{
    public class UpdateProductDto
    {
        [Required]
        [StringLength(MaxLengthProductName)]
        public string ProductName { get; set; }

        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        [StringLength(MaxLengthQuantityPerUnit)]
        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}