using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XiaoLin.VNADS.Configuration;

namespace XiaoLin.VNADS.Web.Host.Startup
{
    [DependsOn(
       typeof(VNADSWebCoreModule))]
    public class VNADSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VNADSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VNADSWebHostModule).GetAssembly());
        }
    }
}
