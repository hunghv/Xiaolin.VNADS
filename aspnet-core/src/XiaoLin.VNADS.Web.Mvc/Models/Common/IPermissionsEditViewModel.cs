using System.Collections.Generic;
using XiaoLin.VNADS.Roles.Dto;

namespace XiaoLin.VNADS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}