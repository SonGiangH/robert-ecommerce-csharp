using RobertEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RobertEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RobertEcommerceEntityFrameworkCoreModule),
    typeof(RobertEcommerceApplicationContractsModule)
    )]
public class RobertEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
