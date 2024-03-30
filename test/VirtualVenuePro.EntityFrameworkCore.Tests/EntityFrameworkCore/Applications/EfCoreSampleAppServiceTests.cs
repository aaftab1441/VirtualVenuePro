using VirtualVenuePro.Samples;
using Xunit;

namespace VirtualVenuePro.EntityFrameworkCore.Applications;

[Collection(VirtualVenueProTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<VirtualVenueProEntityFrameworkCoreTestModule>
{

}
