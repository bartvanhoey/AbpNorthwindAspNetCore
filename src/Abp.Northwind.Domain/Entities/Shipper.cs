using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Northwind.Entities
{
    public class Shipper : FullAuditedEntity<int>
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Orders { get; private set; }
    }
}