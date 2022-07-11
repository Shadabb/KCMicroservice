using Kraken.AdministrationService;
using Kraken.AdministrationService.EntityFrameworkCore;
using Kraken.IdentityService;
using Kraken.IdentityService.EntityFrameworkCore;
using Kraken.ProjectService;
using Kraken.ProjectService.EntityFrameworkCore;
using Kraken.SaaSService;
using Kraken.SaaSService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Kraken.DbMigrator
{
    [DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceApplicationContractsModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule),
    typeof(SaaSServiceEntityFrameworkCoreModule),
    typeof(SaaSServiceApplicationContractsModule),
    typeof(ProjectServiceEntityFrameworkCoreModule),
    typeof(ProjectServiceApplicationContractsModule)
)]
    public class KrakenDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}