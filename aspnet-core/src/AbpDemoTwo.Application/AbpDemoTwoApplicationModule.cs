using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoTwo.Authorization;

namespace AbpDemoTwo
{
    [DependsOn(
        typeof(AbpDemoTwoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpDemoTwoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpDemoTwoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpDemoTwoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
