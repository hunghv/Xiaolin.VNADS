using System.Threading.Tasks;
using Abp.Application.Services;
using XiaoLin.VNADS.Sessions.Dto;

namespace XiaoLin.VNADS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
