using System.Threading.Tasks;
using Abp.Application.Services;
using Booln.MesZero.Sessions.Dto;

namespace Booln.MesZero.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
