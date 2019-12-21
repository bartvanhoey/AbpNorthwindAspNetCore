using Abp.Northwind.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

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
                b.Property(c => c.CategoryName).IsRequired().HasMaxLength(15);
                b.Property(c => c.Description).HasColumnType("ntext");
                b.Property(c => c.Picture).HasColumnType("image");
            });

            builder.Entity<Product>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Products", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Supplier>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Suppliers", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
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
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}