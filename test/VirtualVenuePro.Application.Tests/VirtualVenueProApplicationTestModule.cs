using Volo.Abp.Modularity;

namespace VirtualVenuePro;

[DependsOn(
    typeof(VirtualVenueProApplicationModule),
    typeof(VirtualVenueProDomainTestModule)
)]
public class VirtualVenueProApplicationTestModule : AbpModule
{

}
