using Kraken.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kraken.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
