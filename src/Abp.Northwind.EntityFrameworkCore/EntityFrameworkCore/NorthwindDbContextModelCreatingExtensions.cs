using Abp.Northwind.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;
using static Abp.Northwind.NorthwindSharedDomainConstants.CategoryConsts;
using static Abp.Northwind.NorthwindSharedDomainConstants.CustomerConsts;

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
                b.Property(e => e.ProductName).IsRequired().HasMaxLength(40);
                b.Property(e => e.QuantityPerUnit).HasMaxLength(20);
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
                b.Property(e => e.Address).HasMaxLength(60);
                b.Property(e => e.City).HasMaxLength(15);
                b.Property(e => e.CompanyName).IsRequired().HasMaxLength(40);
                b.Property(e => e.ContactName).HasMaxLength(30);
                b.Property(e => e.ContactTitle).HasMaxLength(30);
                b.Property(e => e.Country).HasMaxLength(15);
                b.Property(e => e.Fax).HasMaxLength(24);
                b.Property(e => e.HomePage).HasColumnType("ntext");
                b.Property(e => e.Phone).HasMaxLength(24);
                b.Property(e => e.PostalCode).HasMaxLength(10);
                b.Property(e => e.Region).HasMaxLength(15);
            });

            builder.Entity<Customer>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Customers", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("CustomerID").HasMaxLength(5).ValueGeneratedNever();
                b.Property(e => e.Address).HasMaxLength(MaxLengthAddress);
                b.Property(e => e.City).HasMaxLength(MaxLengthCity);
                b.Property(e => e.CompanyName).IsRequired().HasMaxLength(MaxLengthCompanyName);
                b.Property(e => e.ContactName).HasMaxLength(MaxLengthContactName);
                b.Property(e => e.ContactTitle).HasMaxLength(MaxLengthContactTitle);
                b.Property(e => e.Country).HasMaxLength(MaxLengthCountry);
                b.Property(e => e.Fax).HasMaxLength(MaxLengthFax);
                b.Property(e => e.Phone).HasMaxLength(MaxLengthPhone);
                b.Property(e => e.PostalCode).HasMaxLength(MaxLengthPostalCode);
                b.Property(e => e.Region).HasMaxLength(MaxLengthRegion);
            });

            builder.Entity<Shipper>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Shippers", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("ShipperID");
                b.Property(e => e.CompanyName).IsRequired().HasMaxLength(40);
                b.Property(e => e.Phone).HasMaxLength(24);
            });

            builder.Entity<Region>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Regions", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.HasKey(e => e.Id).IsClustered(false);
                b.Property(e => e.Id).HasColumnName("RegionID").ValueGeneratedNever();
                b.Property(e => e.RegionDescription).IsRequired().HasMaxLength(50);
            });

            builder.Entity<Territory>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Territories", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.HasKey(e => e.Id).IsClustered(false);
                b.Property(e => e.Id).HasColumnName("TerritoryID").HasMaxLength(20).ValueGeneratedNever();
                b.Property(e => e.RegionId).HasColumnName("RegionID");
                b.Property(e => e.TerritoryDescription).IsRequired().HasMaxLength(50);
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
                b.Property(e => e.TerritoryId).HasColumnName("TerritoryID").HasMaxLength(20);
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
                b.Property(e => e.Address).HasMaxLength(60);
                b.Property(e => e.BirthDate).HasColumnType("datetime");
                b.Property(e => e.City).HasMaxLength(15);
                b.Property(e => e.Country).HasMaxLength(15);
                b.Property(e => e.Extension).HasMaxLength(4);
                b.Property(e => e.FirstName).IsRequired().HasMaxLength(10);
                b.Property(e => e.HireDate).HasColumnType("datetime");
                b.Property(e => e.HomePhone).HasMaxLength(24);
                b.Property(e => e.LastName).IsRequired().HasMaxLength(20);
                b.Property(e => e.Notes).HasColumnType("ntext");
                b.Property(e => e.Photo).HasColumnType("image");
                b.Property(e => e.PhotoPath).HasMaxLength(255);
                b.Property(e => e.PostalCode).HasMaxLength(10);
                b.Property(e => e.Region).HasMaxLength(15);
                b.Property(e => e.Title).HasMaxLength(30);
                b.HasOne(d => d.Manager).WithMany(p => p.DirectReports).HasForeignKey(d => d.ReportsTo)
                    .HasConstraintName("FK_Employees_Employees");
            });

            builder.Entity<Product>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Products", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("ProductID");
                b.Property(e => e.CategoryId).HasColumnName("CategoryID");
                b.Property(e => e.ProductName).IsRequired().HasMaxLength(40);
                b.Property(e => e.QuantityPerUnit).HasMaxLength(20);
                b.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");
                b.Property(e => e.SupplierId).HasColumnName("SupplierID");
                b.Property(e => e.UnitPrice).HasColumnType("money").HasDefaultValueSql("((0))");
                b.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");
                b.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");
            });

            builder.Entity<Order>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Orders", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(e => e.Id).HasColumnName("OrderID");
                b.Property(e => e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5);
                b.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                b.Property(e => e.Freight).HasColumnType("money").HasDefaultValueSql("((0))");
                b.Property(e => e.OrderDate).HasColumnType("datetime");
                b.Property(e => e.RequiredDate).HasColumnType("datetime");
                b.Property(e => e.ShipAddress).HasMaxLength(60);
                b.Property(e => e.ShipCity).HasMaxLength(15);
                b.Property(e => e.ShipCountry).HasMaxLength(15);
                b.Property(e => e.ShipName).HasMaxLength(40);
                b.Property(e => e.ShipPostalCode).HasMaxLength(10);
                b.Property(e => e.ShipRegion).HasMaxLength(15);
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