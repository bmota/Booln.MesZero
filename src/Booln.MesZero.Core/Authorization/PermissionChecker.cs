using Abp.Authorization;
using Booln.MesZero.Authorization.Roles;
using Booln.MesZero.Authorization.Users;

namespace Booln.MesZero.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
