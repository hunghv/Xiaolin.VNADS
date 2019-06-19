using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using XiaoLin.VNADS.Configuration.Dto;

namespace XiaoLin.VNADS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VNADSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
