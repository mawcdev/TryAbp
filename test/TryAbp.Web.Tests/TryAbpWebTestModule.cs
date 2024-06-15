using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TryAbp.EntityFrameworkCore;
using TryAbp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TryAbp.Web.Tests
{
    [DependsOn(
        typeof(TryAbpWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TryAbpWebTestModule : AbpModule
    {
        public TryAbpWebTestModule(TryAbpEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TryAbpWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TryAbpWebMvcModule).Assembly);
        }
    }
}