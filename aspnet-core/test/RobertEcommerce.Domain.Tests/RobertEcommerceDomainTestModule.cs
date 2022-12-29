using RobertEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RobertEcommerce;

[DependsOn(
    typeof(RobertEcommerceEntityFrameworkCoreTestModule)
    )]
public class RobertEcommerceDomainTestModule : AbpModule
{

}
