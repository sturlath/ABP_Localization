using Volo.Abp.Modularity;

namespace test.test
{
    [DependsOn(
        typeof(testApplicationModule),
        typeof(testDomainTestModule)
        )]
    public class testApplicationTestModule : AbpModule
    {

    }
}