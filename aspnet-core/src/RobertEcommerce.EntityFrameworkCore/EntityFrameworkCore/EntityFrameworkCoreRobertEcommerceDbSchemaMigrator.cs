using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RobertEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace RobertEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreRobertEcommerceDbSchemaMigrator
    : IRobertEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRobertEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the RobertEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RobertEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
