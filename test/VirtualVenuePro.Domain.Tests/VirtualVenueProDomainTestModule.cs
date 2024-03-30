using Volo.Abp.Modularity;

namespace VirtualVenuePro;

[DependsOn(
    typeof(VirtualVenueProDomainModule),
    typeof(VirtualVenueProTestBaseModule)
)]
public class VirtualVenueProDomainTestModule : AbpModule
{

}
