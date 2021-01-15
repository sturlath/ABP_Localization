using test.test.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace test.test.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(testEntityFrameworkCoreDbMigrationsModule),
        typeof(testApplicationContractsModule)
        )]
    public class testDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
