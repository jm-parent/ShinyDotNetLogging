using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
        public override void ConfigureLogging(ILoggingBuilder builder, IPlatform platform)
        {
            builder.AddAppCenter("android=eb510724-d123-4b08-9233-79a377e3b44c;" +
                  "uwp={Your UWP App secret here};" +
                  "ios=ios=9e148703-aaaf-4a65-8bee-5d7f4ebedb8d;");
        }
    }
}
