using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace test.test.EntityFrameworkCore
{
    [DependsOn(
        typeof(testEntityFrameworkCoreModule)
        )]
    public class testEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<testMigrationsDbContext>();
        }
    }
}
