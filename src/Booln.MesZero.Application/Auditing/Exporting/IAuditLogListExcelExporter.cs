using System.Collections.Generic;
using Booln.MesZero.Auditing.Dto;
using Booln.MesZero.Dto;

namespace Booln.MesZero.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
