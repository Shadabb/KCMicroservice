using Volo.Abp.Modularity;

namespace Kraken.ProjectService;

[DependsOn(
    typeof(ProjectServiceApplicationModule),
    typeof(ProjectServiceDomainTestModule)
    )]
public class ProjectServiceApplicationTestModule : AbpModule
{

}
