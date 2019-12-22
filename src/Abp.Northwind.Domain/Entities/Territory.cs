using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Northwind.Entities
{
    public class Territory: FullAuditedEntity<string>
    {
        public new string Id { get; set; }
        
        public Territory()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritory>();
        }

        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public Region Region { get; set; }
        public ICollection<EmployeeTerritory> EmployeeTerritories { get; private set; }
    }
}