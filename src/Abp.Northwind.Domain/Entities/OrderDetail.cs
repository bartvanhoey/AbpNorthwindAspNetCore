
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Northwind.Entities
{
    public class OrderDetail: FullAuditedEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
        public override object[] GetKeys()
        {
            return new object[] { OrderId, ProductId};
        }
    }
}