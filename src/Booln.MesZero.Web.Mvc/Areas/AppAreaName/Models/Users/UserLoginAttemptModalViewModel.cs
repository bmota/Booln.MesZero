using System.Collections.Generic;
using Booln.MesZero.Authorization.Users.Dto;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}