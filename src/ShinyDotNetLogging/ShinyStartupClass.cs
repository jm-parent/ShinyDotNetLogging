﻿using Microsoft.Extensions.DependencyInjection;
using Shiny;

namespace ShinyDotNetLogging
{
    public class ShinyStartupClass : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {

            // this is where you'll load things like BLE, GPS, etc - those are covered in other sections
            // things like the jobs, environment, power, are all installed automatically

        }
    }
}
