using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Northwind.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Northwind.DataSeeder
{
    public class TerritoriesSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Territory, string> _repository;
        private readonly List<Territory> _territories = new List<Territory>();

        public TerritoriesSeeder(IRepository<Territory, string> repository)
        {
            _repository = repository;
            AddTerritories();
        }


        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                foreach (var territory in _territories)
                {
                    await _repository.InsertAsync(territory);
                }
            }
        }

        private void AddTerritories()
        {
            _territories.AddRange(new[]
            {
                new Territory {Id = "01581", RegionId = 1, TerritoryDescription = "Westboro"},
                new Territory {Id = "01730", RegionId = 1, TerritoryDescription = "Bedford"},
                new Territory {Id = "01833", RegionId = 1, TerritoryDescription = "Georgetow"},
                new Territory {Id = "02116", RegionId = 1, TerritoryDescription = "Boston"},
                new Territory {Id = "02139", RegionId = 1, TerritoryDescription = "Cambridge"},
                new Territory {Id = "02184", RegionId = 1, TerritoryDescription = "Braintree"},
                new Territory {Id = "02903", RegionId = 1, TerritoryDescription = "Providence"},
                new Territory {Id = "03049", RegionId = 3, TerritoryDescription = "Hollis"},
                new Territory {Id = "03801", RegionId = 3, TerritoryDescription = "Portsmouth"},
                new Territory {Id = "06897", RegionId = 1, TerritoryDescription = "Wilton"},
                new Territory {Id = "07960", RegionId = 1, TerritoryDescription = "Morristown"},
                new Territory {Id = "08837", RegionId = 1, TerritoryDescription = "Edison"},
                new Territory {Id = "10019", RegionId = 1, TerritoryDescription = "New York"},
                new Territory {Id = "10038", RegionId = 1, TerritoryDescription = "New York"},
                new Territory {Id = "11747", RegionId = 1, TerritoryDescription = "Mellvile"},
                new Territory {Id = "14450", RegionId = 1, TerritoryDescription = "Fairport"},
                new Territory {Id = "19428", RegionId = 3, TerritoryDescription = "Philadelphia"},
                new Territory {Id = "19713", RegionId = 1, TerritoryDescription = "Neward"},
                new Territory {Id = "20852", RegionId = 1, TerritoryDescription = "Rockville"},
                new Territory {Id = "27403", RegionId = 1, TerritoryDescription = "Greensboro"},
                new Territory {Id = "27511", RegionId = 1, TerritoryDescription = "Cary"},
                new Territory {Id = "29202", RegionId = 4, TerritoryDescription = "Columbia"},
                new Territory {Id = "30346", RegionId = 4, TerritoryDescription = "Atlanta"},
                new Territory {Id = "31406", RegionId = 4, TerritoryDescription = "Savannah"},
                new Territory {Id = "32859", RegionId = 4, TerritoryDescription = "Orlando"},
                new Territory {Id = "33607", RegionId = 4, TerritoryDescription = "Tampa"},
                new Territory {Id = "40222", RegionId = 1, TerritoryDescription = "Louisville"},
                new Territory {Id = "44122", RegionId = 3, TerritoryDescription = "Beachwood"},
                new Territory {Id = "45839", RegionId = 3, TerritoryDescription = "Findlay"},
                new Territory {Id = "48075", RegionId = 3, TerritoryDescription = "Southfield"},
                new Territory {Id = "48084", RegionId = 3, TerritoryDescription = "Troy"},
                new Territory {Id = "48304", RegionId = 3, TerritoryDescription = "Bloomfield Hills"},
                new Territory {Id = "53404", RegionId = 3, TerritoryDescription = "Racine"},
                new Territory {Id = "55113", RegionId = 3, TerritoryDescription = "Roseville"},
                new Territory {Id = "55439", RegionId = 3, TerritoryDescription = "Minneapolis"},
                new Territory {Id = "60179", RegionId = 2, TerritoryDescription = "Hoffman Estates"},
                new Territory {Id = "60601", RegionId = 2, TerritoryDescription = "Chicago"},
                new Territory {Id = "72716", RegionId = 4, TerritoryDescription = "Bentonville"},
                new Territory {Id = "75234", RegionId = 4, TerritoryDescription = "Dallas"},
                new Territory {Id = "78759", RegionId = 4, TerritoryDescription = "Austin"},
                new Territory {Id = "80202", RegionId = 2, TerritoryDescription = "Denver"},
                new Territory {Id = "80909", RegionId = 2, TerritoryDescription = "Colorado Springs"},
                new Territory {Id = "85014", RegionId = 2, TerritoryDescription = "Phoenix"},
                new Territory {Id = "85251", RegionId = 2, TerritoryDescription = "Scottsdale"},
                new Territory {Id = "90405", RegionId = 2, TerritoryDescription = "Santa Monica"},
                new Territory {Id = "94025", RegionId = 2, TerritoryDescription = "Menlo Park"},
                new Territory {Id = "94105", RegionId = 2, TerritoryDescription = "San Francisco"},
                new Territory {Id = "95008", RegionId = 2, TerritoryDescription = "Campbell"},
                new Territory {Id = "95054", RegionId = 2, TerritoryDescription = "Santa Clara"},
                new Territory {Id = "95060", RegionId = 2, TerritoryDescription = "Santa Cruz"},
                new Territory {Id = "98004", RegionId = 2, TerritoryDescription = "Bellevue"},
                new Territory {Id = "98052", RegionId = 2, TerritoryDescription = "Redmond"},
                new Territory {Id = "98104", RegionId = 2, TerritoryDescription = "Seattle"}
            });
        }
    }
}