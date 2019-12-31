using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Abp.Northwind.Models
{
    public class Category : FullAuditedEntity<int>, IMultiTenant
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<Product> Products { get; private set; }
        public Guid? TenantId { get; }
    }
}