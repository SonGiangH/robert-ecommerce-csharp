using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RobertEcommerce;

[Dependency(ReplaceServices = true)]
public class RobertEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RobertEcommerce";
}
