using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XiaoLin.VNADS.Authorization;

namespace XiaoLin.VNADS
{
    [DependsOn(
        typeof(VNADSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VNADSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VNADSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VNADSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
