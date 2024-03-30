using VirtualVenuePro.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VirtualVenuePro.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class VirtualVenueProController : AbpControllerBase
{
    protected VirtualVenueProController()
    {
        LocalizationResource = typeof(VirtualVenueProResource);
    }
}
