using Volo.Abp.Modularity;

namespace VirtualVenuePro;

/* Inherit from this class for your domain layer tests. */
public abstract class VirtualVenueProDomainTestBase<TStartupModule> : VirtualVenueProTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
