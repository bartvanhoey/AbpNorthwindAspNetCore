using Volo.Abp.Application.Dtos;

namespace Abp.Northwind.ApplicationServices.Shippers.Dtos
{
    public class ShipperDto : AuditedEntityDto<int>
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}