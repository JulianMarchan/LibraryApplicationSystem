using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApplicationSystem.EntityFrameworkCore;
using LibraryApplicationSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LibraryApplicationSystem.Web.Tests
{
    [DependsOn(
        typeof(LibraryApplicationSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LibraryApplicationSystemWebTestModule : AbpModule
    {
        public LibraryApplicationSystemWebTestModule(LibraryApplicationSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryApplicationSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LibraryApplicationSystemWebMvcModule).Assembly);
        }
    }
}