using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace test.test.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class testBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "test";
    }
}
