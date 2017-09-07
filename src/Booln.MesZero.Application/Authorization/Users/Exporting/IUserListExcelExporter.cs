using System.Collections.Generic;
using Booln.MesZero.Authorization.Users.Dto;
using Booln.MesZero.Dto;

namespace Booln.MesZero.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}