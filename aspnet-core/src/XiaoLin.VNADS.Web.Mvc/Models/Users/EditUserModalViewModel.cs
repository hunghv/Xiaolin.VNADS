using System.Collections.Generic;
using System.Linq;
using XiaoLin.VNADS.Roles.Dto;
using XiaoLin.VNADS.Users.Dto;

namespace XiaoLin.VNADS.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
