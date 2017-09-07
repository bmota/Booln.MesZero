using Abp.Notifications;
using Booln.MesZero.Dto;

namespace Booln.MesZero.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}