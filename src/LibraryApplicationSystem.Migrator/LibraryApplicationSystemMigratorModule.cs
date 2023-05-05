using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApplicationSystem.Configuration;
using LibraryApplicationSystem.EntityFrameworkCore;
using LibraryApplicationSystem.Migrator.DependencyInjection;

namespace LibraryApplicationSystem.Migrator
{
    [DependsOn(typeof(LibraryApplicationSystemEntityFrameworkModule))]
    public class LibraryApplicationSystemMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryApplicationSystemMigratorModule(LibraryApplicationSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(LibraryApplicationSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                LibraryApplicationSystemConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryApplicationSystemMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
