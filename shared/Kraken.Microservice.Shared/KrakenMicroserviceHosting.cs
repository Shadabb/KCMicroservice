using Kraken.AdministrationService.EntityFrameworkCore;
using Kraken.SaaSService.EntityFrameworkCore;
using Kraken.Shared.Hosting;
using System;
using Volo.Abp.Modularity;

namespace Kraken.Microservice.Shared
{
    [DependsOn(
    typeof(KrakenHostingModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(SaaSServiceEntityFrameworkCoreModule)
)]
    public class KrakenMicroserviceHosting : AbpModule
    {
    }
}
