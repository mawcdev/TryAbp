using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TryAbp.Authorization;

namespace TryAbp
{
    [DependsOn(
        typeof(TryAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TryAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TryAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TryAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
