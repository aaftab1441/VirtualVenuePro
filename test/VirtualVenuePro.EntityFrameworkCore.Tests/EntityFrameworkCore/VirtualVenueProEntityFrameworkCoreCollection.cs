using Xunit;

namespace VirtualVenuePro.EntityFrameworkCore;

[CollectionDefinition(VirtualVenueProTestConsts.CollectionDefinitionName)]
public class VirtualVenueProEntityFrameworkCoreCollection : ICollectionFixture<VirtualVenueProEntityFrameworkCoreFixture>
{

}
