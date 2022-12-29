using Volo.Abp.Modularity;

namespace RobertEcommerce;

[DependsOn(
    typeof(RobertEcommerceApplicationModule),
    typeof(RobertEcommerceDomainTestModule)
    )]
public class RobertEcommerceApplicationTestModule : AbpModule
{

}
