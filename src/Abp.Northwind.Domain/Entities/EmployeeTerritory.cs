using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Northwind.Entities
{
    public class EmployeeTerritory : FullAuditedEntity
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public Employee Employee { get; set; }
        public Territory Territory { get; set; }

        public override object[] GetKeys()
        {
            return new object[] {EmployeeId, TerritoryId};
        }
    }
}