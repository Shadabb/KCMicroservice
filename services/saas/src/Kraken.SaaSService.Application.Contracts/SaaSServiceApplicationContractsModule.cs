using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.TenantManagement;

namespace Kraken.SaaSService;

[DependsOn(
    typeof(SaaSServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationContractsModule))]
    public class SaaSServiceApplicationContractsModule : AbpModule
{

}
