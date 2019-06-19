using Abp.AutoMapper;
using XiaoLin.VNADS.Authentication.External;

namespace XiaoLin.VNADS.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
