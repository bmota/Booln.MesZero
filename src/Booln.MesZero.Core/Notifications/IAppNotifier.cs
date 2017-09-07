using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Booln.MesZero.Authorization.Users;
using Booln.MesZero.MultiTenancy;

namespace Booln.MesZero.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
