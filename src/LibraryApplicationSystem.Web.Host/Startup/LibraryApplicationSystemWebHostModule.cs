using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApplicationSystem.Configuration;

namespace LibraryApplicationSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(LibraryApplicationSystemWebCoreModule))]
    public class LibraryApplicationSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryApplicationSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryApplicationSystemWebHostModule).GetAssembly());
        }
    }
}
