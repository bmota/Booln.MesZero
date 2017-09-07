using System.Threading.Tasks;
using Abp.Application.Services;
using Booln.MesZero.Configuration.Host.Dto;

namespace Booln.MesZero.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
