using Abp.AutoMapper;
using Booln.MesZero.Authorization.Users;
using Booln.MesZero.Authorization.Users.Dto;
using Booln.MesZero.Web.Areas.AppAreaName.Models.Common;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}