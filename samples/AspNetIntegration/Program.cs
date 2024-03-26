// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license informations

#define ENABLE_MIDDLEWARE

using AspNetIntegration;
using Microsoft.Extensions.Hosting;

#if ENABLE_MIDDLEWARE
    var host = new HostBuilder()
        .ConfigureFunctionsWebApplication(builder =>
        {
        })
        .Build();
    host.Run();
#else
    //<docsnippet_aspnet_registration>
    var host = new HostBuilder()
        .ConfigureFunctionsWebApplication()
        .Build();

    host.Run();
    //</docsnippet_aspnet_registration>
#endif
