using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TryAbp.Configuration;

namespace TryAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(TryAbpWebCoreModule))]
    public class TryAbpWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TryAbpWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TryAbpWebHostModule).GetAssembly());
        }
    }
}
