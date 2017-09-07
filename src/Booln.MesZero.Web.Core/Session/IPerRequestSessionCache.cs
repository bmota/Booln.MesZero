using System.Threading.Tasks;
using Booln.MesZero.Sessions.Dto;

namespace Booln.MesZero.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
