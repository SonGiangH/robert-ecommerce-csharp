using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RobertEcommerce.Data;

/* This is used if database provider does't define
 * IRobertEcommerceDbSchemaMigrator implementation.
 */
public class NullRobertEcommerceDbSchemaMigrator : IRobertEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
