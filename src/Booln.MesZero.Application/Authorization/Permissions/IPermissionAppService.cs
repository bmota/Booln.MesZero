using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Booln.MesZero.Authorization.Permissions.Dto;

namespace Booln.MesZero.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
