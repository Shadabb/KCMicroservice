using Kraken.ProjectService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kraken.ProjectService;

public abstract class ProjectServiceController : AbpControllerBase
{
    protected ProjectServiceController()
    {
        LocalizationResource = typeof(ProjectServiceResource);
    }
}
