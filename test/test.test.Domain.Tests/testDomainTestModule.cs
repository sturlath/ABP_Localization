using test.test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace test.test
{
    [DependsOn(
        typeof(testEntityFrameworkCoreTestModule)
        )]
    public class testDomainTestModule : AbpModule
    {

    }
}