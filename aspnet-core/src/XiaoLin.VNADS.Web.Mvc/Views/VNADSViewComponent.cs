using Abp.AspNetCore.Mvc.ViewComponents;

namespace XiaoLin.VNADS.Web.Views
{
    public abstract class VNADSViewComponent : AbpViewComponent
    {
        protected VNADSViewComponent()
        {
            LocalizationSourceName = VNADSConsts.LocalizationSourceName;
        }
    }
}
