using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Booln.MesZero.Auditing.Dto;
using Booln.MesZero.Dto;

namespace Booln.MesZero.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}