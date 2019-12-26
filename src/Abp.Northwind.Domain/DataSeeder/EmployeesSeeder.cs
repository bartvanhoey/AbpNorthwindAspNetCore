using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class EmployeesSeeder : BaseSeeder, IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Employee, int> _repository;

        public EmployeesSeeder(IRepository<Employee, int> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var employee in Employees.Values)
                {
                    await _repository.InsertAsync(employee);
                }
            }
        }

        
    }
}