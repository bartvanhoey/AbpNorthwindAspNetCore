using Abp.Northwind.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;
using static Abp.Northwind.NorthwindSharedDomainConstants;
using static Abp.Northwind.NorthwindSharedDomainConstants.CategoryConsts;
using static Abp.Northwind.NorthwindSharedDomainConstants.OrderConsts;
using static Abp.Northwind.NorthwindSharedDomainConstants.ProductConsts;
using static Abp.Northwind.NorthwindSharedDomainConstants.RegionConsts;
using static Abp.Northwind.NorthwindSharedDomainConstants.TerritoryConsts;

namespace Abp.Northwind.EntityFrameworkCore
{
    public static class NorthwindDbContextModelCreatingExtensions
    {
        public static void ConfigureNorthwind(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */
            builder.Entity<Category>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Categories", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("CategoryID");
                b.Property(e => e.CategoryName).IsRequired().HasMaxLength(MaxLengthCategoryName);
                b.Property(e => e.Description).HasColumnType("ntext");
                b.Property(e => e.Picture).HasColumnType("image");
            });

            builder.Entity<Product>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Products", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("ProductID");
                b.Property(e => e.CategoryId).HasColumnName("CategoryID");
                b.Property(e => e.ProductName).IsRequired().HasMaxLength(MaxLengthProductName);
                b.Property(e => e.QuantityPerUnit).HasMaxLength(MaxLengthQuantityPerUnit);
                b.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");
                b.Property(e => e.SupplierId).HasColumnName("SupplierID");
                b.Property(e => e.UnitPrice).HasColumnType("money").HasDefaultValueSql("((0))");
                b.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");
                b.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");
            });

            builder.Entity<Supplier>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Suppliers", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("SupplierID");
                b.Property(e => e.Address).HasMaxLength(SupplierConsts.MaxLengthAddress);
                b.Property(e => e.City).HasMaxLength(SupplierConsts.MaxLengthCity);
                b.Property(e => e.CompanyName).IsRequired().HasMaxLength(SupplierConsts.MaxLengthCompanyName);
                b.Property(e => e.ContactName).HasMaxLength(SupplierConsts.MaxLengthContactName);
                b.Property(e => e.ContactTitle).HasMaxLength(SupplierConsts.MaxLengthContactTitle);
                b.Property(e => e.Country).HasMaxLength(SupplierConsts.MaxLengthCountry);
                b.Property(e => e.Fax).HasMaxLength(SupplierConsts.MaxLengthFax);
                b.Property(e => e.HomePage).HasColumnType("ntext");
                b.Property(e => e.Phone).HasMaxLength(SupplierConsts.MaxLengthPhone);
                b.Property(e => e.PostalCode).HasMaxLength(SupplierConsts.MaxLengthPostalCode);
                b.Property(e => e.Region).HasMaxLength(SupplierConsts.MaxLengthRegion);
            });

            builder.Entity<Customer>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Customers", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("CustomerID").HasMaxLength(5).ValueGeneratedNever();
                b.Property(e => e.Address).HasMaxLength(CustomerConsts.MaxLengthAddress);
                b.Property(e => e.City).HasMaxLength(CustomerConsts.MaxLengthCity);
                b.Property(e => e.CompanyName).IsRequired().HasMaxLength(CustomerConsts.MaxLengthCompanyName);
                b.Property(e => e.ContactName).HasMaxLength(CustomerConsts.MaxLengthContactName);
                b.Property(e => e.ContactTitle).HasMaxLength(CustomerConsts.MaxLengthContactTitle);
                b.Property(e => e.Country).HasMaxLength(CustomerConsts.MaxLengthCountry);
                b.Property(e => e.Fax).HasMaxLength(CustomerConsts.MaxLengthFax);
                b.Property(e => e.Phone).HasMaxLength(CustomerConsts.MaxLengthPhone);
                b.Property(e => e.PostalCode).HasMaxLength(CustomerConsts.MaxLengthPostalCode);
                b.Property(e => e.Region).HasMaxLength(CustomerConsts.MaxLengthRegion);
            });

            builder.Entity<Shipper>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Shippers", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("ShipperID");
                b.Property(e => e.CompanyName).IsRequired().HasMaxLength(ShipperConsts.MaxLengthCompanyName);
                b.Property(e => e.Phone).HasMaxLength(ShipperConsts.MaxLengthCompanyName);
            });

            builder.Entity<Region>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Regions", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.HasKey(e => e.Id).IsClustered(false);
                b.Property(e => e.Id).HasColumnName("RegionID").ValueGeneratedNever();
                b.Property(e => e.RegionDescription).IsRequired().HasMaxLength(MaxLengthRegionDescription);
            });

            builder.Entity<Territory>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Territories", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.HasKey(e => e.Id).IsClustered(false);
                b.Property(e => e.Id).HasColumnName("TerritoryID").HasMaxLength(TerritoryConsts.MaxLengthTerritoryId).ValueGeneratedNever();
                b.Property(e => e.RegionId).HasColumnName("RegionID");
                b.Property(e => e.TerritoryDescription).IsRequired().HasMaxLength(MaxLengthTerritoryDescription);
                b.HasOne(d => d.Region)
                    .WithMany(p => p.Territories)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Territories_Region");
            });

            builder.Entity<EmployeeTerritory>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "EmployeeTerritories", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.HasKey(e => new {e.EmployeeId, e.TerritoryId}).IsClustered(false);
                b.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                b.Property(e => e.TerritoryId).HasColumnName("TerritoryID").HasMaxLength(EmployeeTerritoryConsts.MaxLengthTerritoryId);
                b.HasOne(d => d.Employee).WithMany(p => p.EmployeeTerritories).HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EmployeeTerritories_Employees");
                b.HasOne(d => d.Territory).WithMany(p => p.EmployeeTerritories).HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EmployeeTerritories_Territories");
            });

            builder.Entity<Employee>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Employees", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("EmployeeID");
                b.Property(e => e.Address).HasMaxLength(EmployeeConsts.MaxLengthAddress);
                b.Property(e => e.BirthDate).HasColumnType("datetime");
                b.Property(e => e.City).HasMaxLength(EmployeeConsts.MaxLengthCity);
                b.Property(e => e.Country).HasMaxLength(EmployeeConsts.MaxLengthCountry);
                b.Property(e => e.Extension).HasMaxLength(EmployeeConsts.MaxLengthExtension);
                b.Property(e => e.FirstName).IsRequired().HasMaxLength(EmployeeConsts.MaxLengthFirstName);
                b.Property(e => e.HireDate).HasColumnType("datetime");
                b.Property(e => e.HomePhone).HasMaxLength(EmployeeConsts.MaxLengthHomePhone);
                b.Property(e => e.LastName).IsRequired().HasMaxLength(EmployeeConsts.MaxLengthLastName);
                b.Property(e => e.Notes).HasColumnType("ntext");
                b.Property(e => e.Photo).HasColumnType("image");
                b.Property(e => e.PhotoPath).HasMaxLength(EmployeeConsts.MaxLengthPhotoPath);
                b.Property(e => e.PostalCode).HasMaxLength(EmployeeConsts.MaxLengthPostalCode);
                b.Property(e => e.Region).HasMaxLength(EmployeeConsts.MaxLengthRegion);
                b.Property(e => e.Title).HasMaxLength(EmployeeConsts.MaxLengthTitle);
                b.HasOne(d => d.Manager).WithMany(p => p.DirectReports).HasForeignKey(d => d.ReportsTo)
                    .HasConstraintName("FK_Employees_Employees");
            });

            builder.Entity<Order>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Orders", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("OrderID");
                b.Property(e => e.CustomerId).HasColumnName("CustomerID").HasMaxLength(OrderConsts.MaxLengthCustomerId);
                b.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                b.Property(e => e.Freight).HasColumnType("money").HasDefaultValueSql("((0))");
                b.Property(e => e.OrderDate).HasColumnType("datetime");
                b.Property(e => e.RequiredDate).HasColumnType("datetime");
                b.Property(e => e.ShipAddress).HasMaxLength(MaxLengthShipAddress);
                b.Property(e => e.ShipCity).HasMaxLength(MaxLengthShipCity);
                b.Property(e => e.ShipCountry).HasMaxLength(MaxLengthShipCountry);
                b.Property(e => e.ShipName).HasMaxLength(MaxLengthShipName);
                b.Property(e => e.ShipPostalCode).HasMaxLength(MaxLengthShipPostalCode);
                b.Property(e => e.ShipRegion).HasMaxLength(MaxLengthShipRegion);
                b.Property(e => e.ShippedDate).HasColumnType("datetime");
                b.HasOne(d => d.Shipper).WithMany(p => p.Orders).HasForeignKey(d => d.ShipVia)
                    .HasConstraintName("FK_Orders_Shippers");
            });

            builder.Entity<OrderDetail>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "OrderDetails", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.HasKey(e => new {e.OrderId, e.ProductId});
                b.Property(e => e.OrderId).HasColumnName("OrderID");
                b.Property(e => e.ProductId).HasColumnName("ProductID");
                b.Property(e => e.Quantity).HasDefaultValueSql("((1))");
                b.Property(e => e.UnitPrice).HasColumnType("money");
                b.HasOne(d => d.Order).WithMany(p => p.OrderDetails).HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Order_Details_Orders");
                b.HasOne(d => d.Product).WithMany(p => p.OrderDetails).HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Order_Details_Products");
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}