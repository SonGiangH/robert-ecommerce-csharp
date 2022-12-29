using Volo.Abp.Settings;

namespace RobertEcommerce.Settings;

public class RobertEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(RobertEcommerceSettings.MySetting1));
    }
}
