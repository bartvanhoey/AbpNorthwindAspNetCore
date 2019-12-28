using System.Security.Cryptography.X509Certificates;

namespace Abp.Northwind
{
    public static class NorthwindSharedDomainConstants
    {
        public static class CategoryConsts
        {
            public const int MaxLengthCategoryName = 15;
        }

        public static class SupplierConsts
        {
            public const int MaxLengthAddress = 60;
            public const int MaxLengthCity = 25;
            public const int MaxLengthCompanyName = 40;
            public const int MaxLengthContactName = 30;
            public const int MaxLengthContactTitle = 30;
            public const int MaxLengthCountry = 15;
            public const int MaxLengthFax = 24;
            public const int MaxLengthPhone = 24;
            public const int MaxLengthPostalCode = 10;
            public const int MaxLengthRegion = 15;
        }

        public static class CustomerConsts
        {
            public const int MaxLengthAddress = 60;
            public const int MaxLengthCity = 15;
            public const int MaxLengthCompanyName = 40;
            public const int MaxLengthContactName = 30;
            public const int MaxLengthContactTitle = 30;
            public const int MaxLengthCountry = 15;
            public const int MaxLengthFax = 24;
            public const int MaxLengthPhone = 24;
            public const int MaxLengthPostalCode = 10;
            public const int MaxLengthRegion = 60;
        }

        public static class ShipperConsts
        {
            public const int MaxLengthCompanyName = 40;
            public const int MaxLengthPhone = 24;
        }

        public static class RegionConsts
        {
            public const int MaxLengthRegionDescription = 50;
        }

        public static class TerritoryConsts
        {
            public const int MaxLengthTerritoryId = 20;
            public const int MaxLengthTerritoryDescription = 50;
        }

        public static class EmployeeTerritoryConsts
        {
            public const int MaxLengthTerritoryId = 20;
        }

        public static class EmployeeConsts
        {
            public const int MaxLengthAddress = 60;
            public const int MaxLengthCity = 15;
            public const int MaxLengthCountry = 15;
            public const int MaxLengthExtension = 4;
            public const int MaxLengthFirstName = 10;
            public const int MaxLengthHomePhone = 24;
            public const int MaxLengthLastName = 20;
            public const int MaxLengthPhotoPath = 255;
            public const int MaxLengthPostalCode = 10;
            public const int MaxLengthRegion = 15;
            public const int MaxLengthTitle = 30;
        }

        public static class ProductConsts
        {
            public const int MaxLengthProductName = 40;
            public const int MaxLengthQuantityPerUnit = 40;
        }

        public static class OrderConsts
        {
            public const int MaxLengthShipAddress = 60;
            public const int MaxLengthShipCity = 15;
            public const int MaxLengthShipCountry = 15;
            public const int MaxLengthShipName = 40;
            public const int MaxLengthShipPostalCode = 10;
            public const int MaxLengthShipRegion = 15;
        }
    }
}