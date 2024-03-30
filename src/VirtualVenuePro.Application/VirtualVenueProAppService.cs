using System;
using System.Collections.Generic;
using System.Text;
using VirtualVenuePro.Localization;
using Volo.Abp.Application.Services;

namespace VirtualVenuePro;

/* Inherit your application services from this class.
 */
public abstract class VirtualVenueProAppService : ApplicationService
{
    protected VirtualVenueProAppService()
    {
        LocalizationResource = typeof(VirtualVenueProResource);
    }
}
