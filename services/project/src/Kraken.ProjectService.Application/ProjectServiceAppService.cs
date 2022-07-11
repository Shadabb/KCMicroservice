using Kraken.ProjectService.Localization;
using Volo.Abp.Application.Services;

namespace Kraken.ProjectService;

public abstract class ProjectServiceAppService : ApplicationService
{
    protected ProjectServiceAppService()
    {
        LocalizationResource = typeof(ProjectServiceResource);
        ObjectMapperContext = typeof(ProjectServiceApplicationModule);
    }
}
