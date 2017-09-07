using System.Threading.Tasks;

namespace Booln.MesZero.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}