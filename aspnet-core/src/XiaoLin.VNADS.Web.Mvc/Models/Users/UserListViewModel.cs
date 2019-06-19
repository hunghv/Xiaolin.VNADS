using System.Collections.Generic;
using XiaoLin.VNADS.Roles.Dto;
using XiaoLin.VNADS.Users.Dto;

namespace XiaoLin.VNADS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
