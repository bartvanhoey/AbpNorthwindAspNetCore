using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Northwind.Entities
{
    public class Supplier : FullAuditedEntity<int>
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

        public ICollection<Product> Products { get; private set; }

    }
}