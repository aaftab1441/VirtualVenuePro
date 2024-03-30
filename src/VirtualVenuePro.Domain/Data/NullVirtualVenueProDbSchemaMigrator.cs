using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VirtualVenuePro.Data;

/* This is used if database provider does't define
 * IVirtualVenueProDbSchemaMigrator implementation.
 */
public class NullVirtualVenueProDbSchemaMigrator : IVirtualVenueProDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
