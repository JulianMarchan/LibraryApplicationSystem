using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApplicationSystem.Authorization;

namespace LibraryApplicationSystem
{
    [DependsOn(
        typeof(LibraryApplicationSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LibraryApplicationSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LibraryApplicationSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LibraryApplicationSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
