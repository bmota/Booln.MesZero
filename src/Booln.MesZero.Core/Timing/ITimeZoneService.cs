using System.Threading.Tasks;
using Abp.Configuration;

namespace Booln.MesZero.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
