using Abp.AutoMapper;
using XiaoLin.VNADS.Sessions.Dto;

namespace XiaoLin.VNADS.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
