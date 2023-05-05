using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApplicationSystem.Configuration;

namespace LibraryApplicationSystem.Web.Startup
{
    [DependsOn(typeof(LibraryApplicationSystemWebCoreModule))]
    public class LibraryApplicationSystemWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryApplicationSystemWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<LibraryApplicationSystemNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryApplicationSystemWebMvcModule).GetAssembly());
        }
    }
}
