using VirtualVenuePro.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace VirtualVenuePro.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class VirtualVenueProPageModel : AbpPageModel
{
    protected VirtualVenueProPageModel()
    {
        LocalizationResourceType = typeof(VirtualVenueProResource);
    }
}
