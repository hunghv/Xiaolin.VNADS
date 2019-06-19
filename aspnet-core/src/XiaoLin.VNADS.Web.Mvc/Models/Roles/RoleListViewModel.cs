using System.Collections.Generic;
using XiaoLin.VNADS.Roles.Dto;

namespace XiaoLin.VNADS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
