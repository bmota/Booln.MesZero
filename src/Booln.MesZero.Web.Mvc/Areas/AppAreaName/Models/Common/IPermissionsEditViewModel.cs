using System.Collections.Generic;
using Booln.MesZero.Authorization.Permissions.Dto;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}