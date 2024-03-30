using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace VirtualVenuePro.Web;

[Dependency(ReplaceServices = true)]
public class VirtualVenueProBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VirtualVenuePro";
}
