using System.Collections.Generic;
using Booln.MesZero.Authorization.Permissions.Dto;

namespace Booln.MesZero.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}