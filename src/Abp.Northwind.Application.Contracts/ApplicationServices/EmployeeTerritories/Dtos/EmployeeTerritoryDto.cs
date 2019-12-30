using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.EmployeeTerritories.Dtos
{
    public class EmployeeTerritoryDto: AuditedEntityDto<object[]>
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }
    }
}