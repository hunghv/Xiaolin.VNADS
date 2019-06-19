using System.Threading.Tasks;
using Abp.Application.Services;
using XiaoLin.VNADS.Authorization.Accounts.Dto;

namespace XiaoLin.VNADS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
