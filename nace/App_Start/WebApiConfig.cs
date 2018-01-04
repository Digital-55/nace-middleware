﻿using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Extensions;

namespace nace
{
    public static class WebApiConfig
    {
        public async static void Register(HttpConfiguration config)
        {
            // enable query options for all properties
            config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();
            await config.MapRestierRoute<EntityFrameworkApi<Models.nace>>(
                "Nace",
                "api/Nace",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}
