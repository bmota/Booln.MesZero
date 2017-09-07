using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Booln.MesZero.Authorization.Users.Dto;

namespace Booln.MesZero.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
