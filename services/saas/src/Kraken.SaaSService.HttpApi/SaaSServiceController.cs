using Kraken.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kraken.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
