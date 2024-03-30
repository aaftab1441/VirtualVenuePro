using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace VirtualVenuePro.Pages;

public class Index_Tests : VirtualVenueProWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
