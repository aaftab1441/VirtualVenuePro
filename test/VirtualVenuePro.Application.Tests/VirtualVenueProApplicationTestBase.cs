using Volo.Abp.Modularity;

namespace VirtualVenuePro;

public abstract class VirtualVenueProApplicationTestBase<TStartupModule> : VirtualVenueProTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
