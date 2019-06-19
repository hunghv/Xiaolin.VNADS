using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace XiaoLin.VNADS.Web.Views
{
    public abstract class VNADSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected VNADSRazorPage()
        {
            LocalizationSourceName = VNADSConsts.LocalizationSourceName;
        }
    }
}
