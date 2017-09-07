using System.Threading.Tasks;
using Abp.Application.Services;
using Booln.MesZero.Configuration.Tenants.Dto;

namespace Booln.MesZero.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
