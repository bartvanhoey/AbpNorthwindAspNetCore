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
            });
            
            builder.Entity<Product>(b =>
            {
                b.ToTable(NorthwindConsts.DbTablePrefix + "Products", NorthwindConsts.DbSchema);
                b.ConfigureByConvention();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}