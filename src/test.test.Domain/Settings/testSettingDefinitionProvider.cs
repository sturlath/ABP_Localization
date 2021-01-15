using Volo.Abp.Settings;

namespace test.test.Settings
{
    public class testSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(testSettings.MySetting1));
        }
    }
}
