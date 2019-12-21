//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Abp.Northwind.Entities;
//using Volo.Abp.Data;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.Domain.Repositories;
//
//namespace Abp.Northwind.DataSeeder
//{
//    public class SuppliersDataSeedContributor : IDataSeedContributor, ITransientDependency
//    {
//        private readonly IRepository<Supplier, int> _repo;
//        private readonly Dictionary<int, Supplier> _suppliers = new Dictionary<int, Supplier>();
//
//        public SuppliersDataSeedContributor(IRepository<Supplier, int> repo)
//        {
//            _repo = repo;
//            AddSuppliers();
//        }
//
//        public async Task SeedAsync(DataSeedContext context)
//        {
//            if (await _repo.GetCountAsync() <= 0)
//            {
//                foreach (var supplier in _suppliers.Values)
//                {
//                    await _repo.InsertAsync(supplier);
//                }
//            }
//        }
//
//        private void AddSuppliers()
//        {
//            _suppliers.Add(1,
//                new Supplier
//                {
//                    CompanyName = "Exotic Liquids", ContactName = "Charlotte Cooper",
//                    ContactTitle = "Purchasing Manager", Address = "49 Gilbert St.", City = "London",
//                    PostalCode = "EC1 4SD", Fax = "", Phone = "(171) 555-2222", HomePage = ""
//                });
//            _suppliers.Add(2,
//                new Supplier
//                {
//                    CompanyName = "New Orleans Cajun Delights", ContactName = "Shelley Burke",
//                    ContactTitle = "Order Administrator", Address = "P.O. Box 78934", City = "New Orleans",
//                    Region = "LA", PostalCode = "70117", Fax = "", Phone = "(100) 555-4822", HomePage = "#CAJUN.HTM#"
//                });
//            _suppliers.Add(3,
//                new Supplier
//                {
//                    CompanyName = "Grandma Kelly's Homestead", ContactName = "Regina Murphy",
//                    ContactTitle = "Sales Representative", Address = "707 Oxford Rd.", City = "Ann Arbor",
//                    Region = "MI", PostalCode = "48104", Fax = "(313) 555-3349", Phone = "(313) 555-5735", HomePage = ""
//                });
//            _suppliers.Add(4,
//                new Supplier
//                {
//                    CompanyName = "Tokyo Traders", ContactName = "Yoshi Nagase", ContactTitle = "Marketing Manager",
//                    Address = "9-8 Sekimai Musashino-shi", City = "Tokyo", PostalCode = "100", Fax = "",
//                    Phone = "(03) 3555-5011", HomePage = ""
//                });
//            _suppliers.Add(5,
//                new Supplier
//                {
//                    CompanyName = "Cooperativa de Quesos 'Las Cabras'", ContactName = "Antonio del Valle Saavedra",
//                    ContactTitle = "Export Administrator", Address = "Calle del Rosal 4", City = "Oviedo",
//                    Region = "Asturias", PostalCode = "33007", Fax = "", Phone = "(98) 598 76 54", HomePage = ""
//                });
//            _suppliers.Add(6,
//                new Supplier
//                {
//                    CompanyName = "Mayumi's", ContactName = "Mayumi Ohno", ContactTitle = "Marketing Representative",
//                    Address = "92 Setsuko Chuo-ku", City = "Osaka", PostalCode = "545", Fax = "",
//                    Phone = "(06) 431-7877",
//                    HomePage =
//                        "Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#"
//                });
//            _suppliers.Add(7,
//                new Supplier
//                {
//                    CompanyName = "Pavlova, Ltd.", ContactName = "Ian Devling", ContactTitle = "Marketing Manager",
//                    Address = "74 Rose St. Moonie Ponds", City = "Melbourne", Region = "Victoria", PostalCode = "3058",
//                    Fax = "(03) 444-6588", Phone = "(03) 444-2343", HomePage = ""
//                });
//            _suppliers.Add(8,
//                new Supplier
//                {
//                    CompanyName = "Specialty Biscuits, Ltd.", ContactName = "Peter Wilson",
//                    ContactTitle = "Sales Representative", Address = "29 King's Way", City = "Manchester",
//                    PostalCode = "M14 GSD", Fax = "", Phone = "(161) 555-4448", HomePage = ""
//                });
//            _suppliers.Add(9,
//                new Supplier
//                {
//                    CompanyName = "PB Knäckebröd AB", ContactName = "Lars Peterson", ContactTitle = "Sales Agent",
//                    Address = "Kaloadagatan 13", City = "Göteborg", PostalCode = "S-345 67", Fax = "031-987 65 91",
//                    Phone = "031-987 65 43", HomePage = ""
//                });
//            _suppliers.Add(10,
//                new Supplier
//                {
//                    CompanyName = "Refrescos Americanas LTDA", ContactName = "Carlos Diaz",
//                    ContactTitle = "Marketing Manager", Address = "Av. das Americanas 12.890", City = "Sao Paulo",
//                    PostalCode = "5442", Fax = "", Phone = "(11) 555 4640", HomePage = ""
//                });
//            _suppliers.Add(11,
//                new Supplier
//                {
//                    CompanyName = "Heli Süßwaren GmbH & Co. KG", ContactName = "Petra Winkler",
//                    ContactTitle = "Sales Manager", Address = "Tiergartenstraße 5", City = "Berlin",
//                    PostalCode = "10785", Fax = "", Phone = "(010) 9984510", HomePage = ""
//                });
//            _suppliers.Add(12,
//                new Supplier
//                {
//                    CompanyName = "Plutzer Lebensmittelgroßmärkte AG", ContactName = "Martin Bein",
//                    ContactTitle = "International Marketing Mgr.", Address = "Bogenallee 51", City = "Frankfurt",
//                    PostalCode = "60439", Fax = "", Phone = "(069) 992755",
//                    HomePage =
//                        "Plutzer (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/plutzer.htm#"
//                });
//            _suppliers.Add(13,
//                new Supplier
//                {
//                    CompanyName = "Nord-Ost-Fisch Handelsgesellschaft mbH", ContactName = "Sven Petersen",
//                    ContactTitle = "Coordinator Foreign Markets", Address = "Frahmredder 112a", City = "Cuxhaven",
//                    PostalCode = "27478", Fax = "(04721) 8714", Phone = "(04721) 8713", HomePage = ""
//                });
//            _suppliers.Add(14,
//                new Supplier
//                {
//                    CompanyName = "Formaggi Fortini s.r.l.", ContactName = "Elio Rossi",
//                    ContactTitle = "Sales Representative", Address = "Viale Dante, 75", City = "Ravenna",
//                    PostalCode = "48100", Fax = "(0544) 60603", Phone = "(0544) 60323", HomePage = "#FORMAGGI.HTM#"
//                });
//            _suppliers.Add(15,
//                new Supplier
//                {
//                    CompanyName = "Norske Meierier", ContactName = "Beate Vileid", ContactTitle = "Marketing Manager",
//                    Address = "Hatlevegen 5", City = "Sandvika", PostalCode = "1320", Fax = "", Phone = "(0)2-953010",
//                    HomePage = ""
//                });
//            _suppliers.Add(16,
//                new Supplier
//                {
//                    CompanyName = "Bigfoot Breweries", ContactName = "Cheryl Saylor",
//                    ContactTitle = "Regional Account Rep.", Address = "3400 - 8th Avenue Suite 210", City = "Bend",
//                    Region = "OR", PostalCode = "97101", Fax = "", Phone = "(503) 555-9931", HomePage = ""
//                });
//            _suppliers.Add(17,
//                new Supplier
//                {
//                    CompanyName = "Svensk Sjöföda AB", ContactName = "Michael Björn",
//                    ContactTitle = "Sales Representative", Address = "Brovallavägen 231", City = "Stockholm",
//                    PostalCode = "S-123 45", Fax = "", Phone = "08-123 45 67", HomePage = ""
//                });
//            _suppliers.Add(18,
//                new Supplier
//                {
//                    CompanyName = "Aux joyeux ecclésiastiques", ContactName = "Guylène Nodier",
//                    ContactTitle = "Sales Manager", Address = "203, Rue des Francs-Bourgeois", City = "Paris",
//                    PostalCode = "75004", Fax = "(1) 03.83.00.62", Phone = "(1) 03.83.00.68", HomePage = ""
//                });
//            _suppliers.Add(19,
//                new Supplier
//                {
//                    CompanyName = "New England Seafood Cannery", ContactName = "Robb Merchant",
//                    ContactTitle = "Wholesale Account Agent", Address = "Order Processing Dept. 2100 Paul Revere Blvd.",
//                    City = "Boston", Region = "MA", PostalCode = "02134", Fax = "(617) 555-3389",
//                    Phone = "(617) 555-3267", HomePage = ""
//                });
//            _suppliers.Add(20,
//                new Supplier
//                {
//                    CompanyName = "Leka Trading", ContactName = "Chandra Leka", ContactTitle = "Owner",
//                    Address = "471 Serangoon Loop, Suite #402", City = "Singapore", PostalCode = "0512", Fax = "",
//                    Phone = "555-8787", HomePage = ""
//                });
//            _suppliers.Add(21,
//                new Supplier
//                {
//                    CompanyName = "Lyngbysild", ContactName = "Niels Petersen", ContactTitle = "Sales Manager",
//                    Address = "Lyngbysild Fiskebakken 10", City = "Lyngby", PostalCode = "2800", Fax = "43844115",
//                    Phone = "43844108", HomePage = ""
//                });
//            _suppliers.Add(22,
//                new Supplier
//                {
//                    CompanyName = "Zaanse Snoepfabriek", ContactName = "Dirk Luchte",
//                    ContactTitle = "Accounting Manager", Address = "Verkoop Rijnweg 22", City = "Zaandam",
//                    PostalCode = "9999 ZZ", Fax = "(12345) 1210", Phone = "(12345) 1212", HomePage = ""
//                });
//            _suppliers.Add(23,
//                new Supplier
//                {
//                    CompanyName = "Karkki Oy", ContactName = "Anne Heikkonen", ContactTitle = "Product Manager",
//                    Address = "Valtakatu 12", City = "Lappeenranta", PostalCode = "53120", Fax = "",
//                    Phone = "(953) 10956", HomePage = ""
//                });
//            _suppliers.Add(24,
//                new Supplier
//                {
//                    CompanyName = "G'day, Mate", ContactName = "Wendy Mackenzie", ContactTitle = "Sales Representative",
//                    Address = "170 Prince Edward Parade Hunter's Hill", City = "Sydney", Region = "NSW",
//                    PostalCode = "2042", Fax = "(02) 555-4873", Phone = "(02) 555-5914",
//                    HomePage =
//                        "G'day Mate (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/gdaymate.htm#"
//                });
//            _suppliers.Add(25,
//                new Supplier
//                {
//                    CompanyName = "Ma Maison", ContactName = "Jean-Guy Lauzon", ContactTitle = "Marketing Manager",
//                    Address = "2960 Rue St. Laurent", City = "Montréal", Region = "Québec", PostalCode = "H1J 1C3",
//                    Fax = "", Phone = "(514) 555-9022", HomePage = ""
//                });
//            _suppliers.Add(26,
//                new Supplier
//                {
//                    CompanyName = "Pasta Buttini s.r.l.", ContactName = "Giovanni Giudici",
//                    ContactTitle = "Order Administrator", Address = "Via dei Gelsomini, 153", City = "Salerno",
//                    PostalCode = "84100", Fax = "(089) 6547667", Phone = "(089) 6547665", HomePage = ""
//                });
//            _suppliers.Add(27,
//                new Supplier
//                {
//                    CompanyName = "Escargots Nouveaux", ContactName = "Marie Delamare", ContactTitle = "Sales Manager",
//                    Address = "22, rue H. Voiron", City = "Montceau", PostalCode = "71300", Fax = "",
//                    Phone = "85.57.00.07", HomePage = ""
//                });
//            _suppliers.Add(28,
//                new Supplier
//                {
//                    CompanyName = "Gai pâturage", ContactName = "Eliane Noz", ContactTitle = "Sales Representative",
//                    Address = "Bat. B 3, rue des Alpes", City = "Annecy", PostalCode = "74000", Fax = "38.76.98.58",
//                    Phone = "38.76.98.06", HomePage = ""
//                });
//            _suppliers.Add(29,
//                new Supplier
//                {
//                    CompanyName = "Forêts d'érables", ContactName = "Chantal Goulet",
//                    ContactTitle = "Accounting Manager", Address = "148 rue Chasseur", City = "Ste-Hyacinthe",
//                    Region = "Québec", PostalCode = "J2S 7S8", Fax = "(514) 555-2921", Phone = "(514) 555-2955",
//                    HomePage = ""
//                });
//        }
//    }
//}