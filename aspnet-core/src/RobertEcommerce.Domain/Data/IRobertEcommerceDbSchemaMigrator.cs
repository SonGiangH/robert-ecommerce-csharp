using System.Threading.Tasks;

namespace RobertEcommerce.Data;

public interface IRobertEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
