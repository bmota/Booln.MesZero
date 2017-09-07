using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Booln.MesZero.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
