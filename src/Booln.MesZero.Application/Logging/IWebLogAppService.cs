using Abp.Application.Services;
using Booln.MesZero.Dto;
using Booln.MesZero.Logging.Dto;

namespace Booln.MesZero.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
