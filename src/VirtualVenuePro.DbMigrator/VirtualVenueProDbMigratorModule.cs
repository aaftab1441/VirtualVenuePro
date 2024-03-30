using VirtualVenuePro.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace VirtualVenuePro.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(VirtualVenueProEntityFrameworkCoreModule),
    typeof(VirtualVenueProApplicationContractsModule)
    )]
public class VirtualVenueProDbMigratorModule : AbpModule
{
}
