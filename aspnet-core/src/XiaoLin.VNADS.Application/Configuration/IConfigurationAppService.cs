using System.Threading.Tasks;
using XiaoLin.VNADS.Configuration.Dto;

namespace XiaoLin.VNADS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
