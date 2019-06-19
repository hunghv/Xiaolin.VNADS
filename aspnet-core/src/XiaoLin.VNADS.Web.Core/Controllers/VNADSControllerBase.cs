using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace XiaoLin.VNADS.Controllers
{
    public abstract class VNADSControllerBase: AbpController
    {
        protected VNADSControllerBase()
        {
            LocalizationSourceName = VNADSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
