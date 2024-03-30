using VirtualVenuePro.Samples;
using Xunit;

namespace VirtualVenuePro.EntityFrameworkCore.Domains;

[Collection(VirtualVenueProTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<VirtualVenueProEntityFrameworkCoreTestModule>
{

}
