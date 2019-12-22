using Volo.Abp.Domain.Entities;

namespace Abp.Northwind.Entities
{
    public class EmployeeTerritory : Entity
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