using System.Threading.Tasks;

namespace VirtualVenuePro.Data;

public interface IVirtualVenueProDbSchemaMigrator
{
    Task MigrateAsync();
}
