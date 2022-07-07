﻿using Kraken.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kraken.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
