using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoTwo.Configuration;

namespace AbpDemoTwo.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpDemoTwoWebCoreModule))]
    public class AbpDemoTwoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpDemoTwoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpDemoTwoWebHostModule).GetAssembly());
        }
    }
}
