using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using XiaoLin.VNADS.Roles.Dto;
using XiaoLin.VNADS.Users.Dto;

namespace XiaoLin.VNADS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
