using System.Threading.Tasks;
using Abp.Application.Services;
using Booln.MesZero.Editions.Dto;
using Booln.MesZero.MultiTenancy.Dto;

namespace Booln.MesZero.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}