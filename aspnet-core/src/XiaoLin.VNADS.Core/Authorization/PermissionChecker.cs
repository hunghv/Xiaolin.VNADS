using Abp.Authorization;
using XiaoLin.VNADS.Authorization.Roles;
using XiaoLin.VNADS.Authorization.Users;

namespace XiaoLin.VNADS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
