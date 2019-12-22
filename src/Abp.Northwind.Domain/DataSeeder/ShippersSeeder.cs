using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class ShippersSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Shipper, int> _repository;
        private readonly Dictionary<int, Shipper> _shippers = new Dictionary<int, Shipper>();

        public ShippersSeeder(IRepository<Shipper, int> repository)
        {
            _repository = repository;
            AddShippers();
        }


        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var shipper in _shippers.Values)
                {
                    await _repository.InsertAsync(shipper);
                }
            }
        }
        
        private void AddShippers()
        {
            _shippers.Add(1, new Shipper {CompanyName = "Speedy Express", Phone = "(503) 555-9831"});
            _shippers.Add(2, new Shipper {CompanyName = "United Package", Phone = "(503) 555-3199"});
            _shippers.Add(3, new Shipper {CompanyName = "Federal Shipping", Phone = "(503) 555-9931"});
        }
    }

    internal class Shippers
    {
    }
}