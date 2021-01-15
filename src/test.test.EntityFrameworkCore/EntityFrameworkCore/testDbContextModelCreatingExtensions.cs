using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace test.test.EntityFrameworkCore
{
    public static class testDbContextModelCreatingExtensions
    {
        public static void Configuretest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(testConsts.DbTablePrefix + "YourEntities", testConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}